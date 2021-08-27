﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Blockfrost.Api.Http
{
    /// <summary>
    /// Middleware for client side request throttling.
    /// Allows a burst of 500 requests, which cools off at rate of 10 requests per second.
    /// If the request limit is reached, the thread waits until new requests are allowed.
    /// No requests are dropped, they are simply delayed.
    /// </summary>
    public class RequestThrottler : DelegatingHandler
    {
        readonly SemaphoreSlim _mutex = new(1, 1);
        int _requestCount = 0;
        DateTimeOffset _lastRequestTime = DateTimeOffset.UtcNow;

        public RequestThrottler(BlockfrostAuthorizationHandler innerHandler) : base(innerHandler)
        {
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            await _mutex.WaitAsync(cancellationToken).ConfigureAwait(false);
            try
            {
                TimeSpan timeSinceLastCall = DateTimeOffset.UtcNow - _lastRequestTime;
                int cooledOffRequests = timeSinceLastCall.Seconds * Constants.BURST_COOLDOWN_10;
                _requestCount = _requestCount > cooledOffRequests ? _requestCount - cooledOffRequests : 0;

                while (_requestCount >= Constants.BURST_LIMIT_500)
                {
                    await Task.Delay(TimeSpan.FromMilliseconds(Constants.BURST_COOLDOWN_INTERVAL_1000), cancellationToken).ConfigureAwait(false);
                    _requestCount -= Constants.BURST_COOLDOWN_10;
                }

                _lastRequestTime = DateTimeOffset.UtcNow;
                _requestCount++;
            }
            finally
            {
                _mutex.Release();
            }

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}

