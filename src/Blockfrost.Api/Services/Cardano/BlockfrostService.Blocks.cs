﻿#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Collections.Generic;
namespace Blockfrost.Api
{
    public partial class BlockfrostService : IBlockfrostService
    {

        /// <summary>Specific block in a slot in an epoch</summary>
        /// <param name="epoch_number">Epoch for specific epoch slot.</param>
        /// <param name="slot_number">Slot position for requested block.</param>
        /// <returns>Return the contents of the block</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BlockContent> GetSlotAsync(int epoch_number, int slot_number)
        {
            return GetSlotAsync(epoch_number, slot_number, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Specific block in a slot in an epoch</summary>
        /// <param name="epoch_number">Epoch for specific epoch slot.</param>
        /// <param name="slot_number">Slot position for requested block.</param>
        /// <returns>Return the contents of the block</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BlockContent> GetSlotAsync(int epoch_number, int slot_number, CancellationToken cancellationToken)
        {
            if (epoch_number == null)
                throw new System.ArgumentNullException("epoch_number");

            if (slot_number == null)
                throw new System.ArgumentNullException("slot_number");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks/epoch/{epoch_number}/slot/{slot_number}");
            urlBuilder_.Replace("{epoch_number}", System.Uri.EscapeDataString(ConvertToString(epoch_number, System.Globalization.CultureInfo.InvariantCulture)));
            urlBuilder_.Replace("{slot_number}", System.Uri.EscapeDataString(ConvertToString(slot_number, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<BlockContent>(urlBuilder_, cancellationToken);
        }
        /// <summary>Latest block</summary>
        /// <returns>Return the contents of the latest block.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BlockContent> GetLatestBlockAsync()
        {
            return GetLatestBlockAsync(CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Latest block</summary>
        /// <returns>Return the contents of the latest block.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BlockContent> GetLatestBlockAsync(CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks/latest");

            return await SendGetRequestAsync<BlockContent>(urlBuilder_, cancellationToken);
        }

        /// <summary>Latest block transactions</summary>
        /// <param name="count">The number of results displayed on one page.</param>
        /// <param name="page">The page number for listing the results.</param>
        /// <param name="order">Ordered by tx index in the block.
        /// <br/>The ordering of items from the point of view of the blockchain,
        /// <br/>not the page listing itself. By default, we return oldest first, newest last.</param>
        /// <returns>Return the transactions within the block.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<string>> TxsAllAsync(int? count, int? page, Order? order)
        {
            return TxsAllAsync(count, page, order, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Latest block transactions</summary>
        /// <param name="count">The number of results displayed on one page.</param>
        /// <param name="page">The page number for listing the results.</param>
        /// <param name="order">Ordered by tx index in the block.
        /// <br/>The ordering of items from the point of view of the blockchain,
        /// <br/>not the page listing itself. By default, we return oldest first, newest last.</param>
        /// <returns>Return the transactions within the block.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<string>> TxsAllAsync(int? count, int? page, Order? order, CancellationToken cancellationToken)
        {
            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks/latest/txs?");
            if (count != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("count") + "=").Append(System.Uri.EscapeDataString(ConvertToString(count, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (page != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("page") + "=").Append(System.Uri.EscapeDataString(ConvertToString(page, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (order != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("order") + "=").Append(System.Uri.EscapeDataString(ConvertToString(order, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            return await SendGetRequestAsync<ICollection<string>>(urlBuilder_, cancellationToken);
        }

        /// <summary>Specific block</summary>
        /// <param name="hash_or_number">Hash of the requested block.</param>
        /// <returns>Return the contents of the block</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BlockContent> GetBlocksAsync(string hash_or_number)
        {
            return GetBlocksAsync(hash_or_number, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Specific block</summary>
        /// <param name="hash_or_number">Hash of the requested block.</param>
        /// <returns>Return the contents of the block</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BlockContent> GetBlocksAsync(string hash_or_number, CancellationToken cancellationToken)
        {
            if (hash_or_number == null)
                throw new System.ArgumentNullException("hash_or_number");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks/{hash_or_number}");
            urlBuilder_.Replace("{hash_or_number}", System.Uri.EscapeDataString(ConvertToString(hash_or_number, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<BlockContent>(urlBuilder_, cancellationToken);
        }

        /// <summary>Specific block in a slot</summary>
        /// <param name="slot_number">Slot position for requested block.</param>
        /// <returns>Return the contents of the block</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<BlockContent> SlotAsync(int slot_number)
        {
            return GetSlotAsync(slot_number, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Specific block in a slot</summary>
        /// <param name="slot_number">Slot position for requested block.</param>
        /// <returns>Return the contents of the block</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<BlockContent> GetSlotAsync(int slot_number, CancellationToken cancellationToken)
        {
            if (slot_number == null)
                throw new System.ArgumentNullException("slot_number");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks/slot/{slot_number}");
            urlBuilder_.Replace("{slot_number}", System.Uri.EscapeDataString(ConvertToString(slot_number, System.Globalization.CultureInfo.InvariantCulture)));

            return await SendGetRequestAsync<BlockContent>(urlBuilder_, cancellationToken);
        }



        /// <summary>Listing of next blocks</summary>
        /// <param name="hash_or_number">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page.</param>
        /// <param name="page">The page number for listing the results.</param>
        /// <returns>Return the contents of the block.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<BlockContent>> GetNextBlockAsync(string hash_or_number, int? count, int? page)
        {
            return GetNextBlockAsync(hash_or_number, count, page, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Listing of next blocks</summary>
        /// <param name="hash_or_number">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page.</param>
        /// <param name="page">The page number for listing the results.</param>
        /// <returns>Return the contents of the block.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<BlockContent>> GetNextBlockAsync(string hash_or_number, int? count, int? page, CancellationToken cancellationToken)
        {
            if (hash_or_number == null)
                throw new System.ArgumentNullException("hash_or_number");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks/{hash_or_number}/next?");
            urlBuilder_.Replace("{hash_or_number}", System.Uri.EscapeDataString(ConvertToString(hash_or_number, System.Globalization.CultureInfo.InvariantCulture)));
            if (count != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("count") + "=").Append(System.Uri.EscapeDataString(ConvertToString(count, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (page != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("page") + "=").Append(System.Uri.EscapeDataString(ConvertToString(page, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            return await SendGetRequestAsync<ICollection<BlockContent>>(urlBuilder_, cancellationToken);
        }


        /// <summary>Listing of previous blocks</summary>
        /// <param name="hash_or_number">Hash of the requested block</param>
        /// <param name="count">The number of results displayed on one page.</param>
        /// <param name="page">The page number for listing the results.</param>
        /// <returns>Return the contents of the block</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<BlockContent>> PreviousAsync(string hash_or_number, int? count, int? page)
        {
            return PreviousAsync(hash_or_number, count, page, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Listing of previous blocks</summary>
        /// <param name="hash_or_number">Hash of the requested block</param>
        /// <param name="count">The number of results displayed on one page.</param>
        /// <param name="page">The page number for listing the results.</param>
        /// <returns>Return the contents of the block</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<BlockContent>> PreviousAsync(string hash_or_number, int? count, int? page, CancellationToken cancellationToken)
        {
            if (hash_or_number == null)
                throw new System.ArgumentNullException("hash_or_number");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks/{hash_or_number}/previous?");
            urlBuilder_.Replace("{hash_or_number}", System.Uri.EscapeDataString(ConvertToString(hash_or_number, System.Globalization.CultureInfo.InvariantCulture)));
            if (count != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("count") + "=").Append(System.Uri.EscapeDataString(ConvertToString(count, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (page != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("page") + "=").Append(System.Uri.EscapeDataString(ConvertToString(page, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            return await SendGetRequestAsync<ICollection<BlockContent>>(urlBuilder_, cancellationToken);
        }

        /// <summary>Block transactions</summary>
        /// <param name="hash_or_number">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page.</param>
        /// <param name="page">The page number for listing the results.</param>
        /// <param name="order">Ordered by tx index in the block.
        /// <br/>The ordering of items from the point of view of the blockchain,
        /// <br/>not the page listing itself. By default, we return oldest first, newest last.</param>
        /// <returns>Return the transactions within the block.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public Task<ICollection<string>> TxsAll2Async(string hash_or_number, int? count, int? page, Order2? order)
        {
            return TxsAll2Async(hash_or_number, count, page, order, CancellationToken.None);
        }

        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <summary>Block transactions</summary>
        /// <param name="hash_or_number">Hash of the requested block.</param>
        /// <param name="count">The number of results displayed on one page.</param>
        /// <param name="page">The page number for listing the results.</param>
        /// <param name="order">Ordered by tx index in the block.
        /// <br/>The ordering of items from the point of view of the blockchain,
        /// <br/>not the page listing itself. By default, we return oldest first, newest last.</param>
        /// <returns>Return the transactions within the block.</returns>
        /// <exception cref="ApiException">A server side error occurred.</exception>
        public async Task<ICollection<string>> TxsAll2Async(string hash_or_number, int? count, int? page, Order2? order, CancellationToken cancellationToken)
        {
            if (hash_or_number == null)
                throw new System.ArgumentNullException("hash_or_number");

            var urlBuilder_ = new System.Text.StringBuilder();
            urlBuilder_.Append(BaseUrl != null ? BaseUrl.TrimEnd('/') : "").Append("/blocks/{hash_or_number}/txs?");
            urlBuilder_.Replace("{hash_or_number}", System.Uri.EscapeDataString(ConvertToString(hash_or_number, System.Globalization.CultureInfo.InvariantCulture)));
            if (count != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("count") + "=").Append(System.Uri.EscapeDataString(ConvertToString(count, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (page != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("page") + "=").Append(System.Uri.EscapeDataString(ConvertToString(page, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            if (order != null)
            {
                urlBuilder_.Append(System.Uri.EscapeDataString("order") + "=").Append(System.Uri.EscapeDataString(ConvertToString(order, System.Globalization.CultureInfo.InvariantCulture))).Append("&");
            }
            urlBuilder_.Length--;

            return await SendGetRequestAsync<ICollection<string>>(urlBuilder_, cancellationToken);
        }
    }
}


#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore 472
#pragma warning restore 114
#pragma warning restore 108
#pragma warning restore 3016