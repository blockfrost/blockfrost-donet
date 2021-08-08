﻿using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Blockfrost.Api
{
    public interface IBlockfrostService
    {
        string BaseUrl { get; set; }
        bool ReadResponseAsString { get; set; }

        Task<Account_content> GetAccountsAsync(string stake_address);
        Task<Account_content> GetAccountsAsync(string stake_address, CancellationToken cancellationToken);
        Task<Response12> Add2Async(string iPFS_path);
        Task<Response12> Add2Async(string iPFS_path, CancellationToken cancellationToken);
        Task<Response11> AddAsync();
        Task<Response11> AddAsync(CancellationToken cancellationToken);
        Task<ICollection<Anonymous30>> AddressesAll2Async(string asset, int? count, int? page, Order30? order);
        Task<ICollection<Anonymous30>> AddressesAll2Async(string asset, int? count, int? page, Order30? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous15>> AddressesAllAsync(string stake_address, int? count, int? page, Order11? order);
        Task<ICollection<Anonymous15>> AddressesAllAsync(string stake_address, int? count, int? page, Order11? order, CancellationToken cancellationToken);
        Task<Address_content> AddressesAsync(string address);
        Task<Address_content> AddressesAsync(string address, CancellationToken cancellationToken);
        Task<AnonymousResponse> AnonymousAsync();
        Task<AnonymousResponse> AnonymousAsync(CancellationToken cancellationToken);
        Task<ICollection<Anonymous27>> AssetsAll2Async(int? count, int? page, Order26? order);
        Task<ICollection<Anonymous27>> AssetsAll2Async(int? count, int? page, Order26? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous16>> AssetsAllAsync(string stake_address, int? count, int? page, Order12? order);
        Task<ICollection<Anonymous16>> AssetsAllAsync(string stake_address, int? count, int? page, Order12? order, CancellationToken cancellationToken);
        Task<Asset> AssetsAsync(string asset);
        Task<Asset> AssetsAsync(string asset, CancellationToken cancellationToken);
        Task<ICollection<string>> BlocksAll2Async(int number, string pool_id, int? count, int? page, Order4? order);
        Task<ICollection<string>> BlocksAll2Async(int number, string pool_id, int? count, int? page, Order4? order, CancellationToken cancellationToken);
        Task<ICollection<string>> BlocksAll3Async(string pool_id, int? count, int? page, Order24? order);
        Task<ICollection<string>> BlocksAll3Async(string pool_id, int? count, int? page, Order24? order, CancellationToken cancellationToken);
        Task<ICollection<string>> BlocksAllAsync(int number, int? count, int? page, Order3? order);
        Task<ICollection<string>> BlocksAllAsync(int number, int? count, int? page, Order3? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous19>> Cbor2Async(string label, int? count, int? page, Order15? order);
        Task<ICollection<Anonymous19>> Cbor2Async(string label, int? count, int? page, Order15? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous8>> CborAsync(string hash);
        Task<ICollection<Anonymous8>> CborAsync(string hash, CancellationToken cancellationToken);
        Task<Clock> GetClockAsync();
        Task<ICollection<Anonymous11>> Delegations2Async(string stake_address, int? count, int? page, Order7? order);
        Task<ICollection<Anonymous11>> Delegations2Async(string stake_address, int? count, int? page, Order7? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous4>> DelegationsAsync(string hash);
        Task<ICollection<Anonymous4>> DelegationsAsync(string hash, CancellationToken cancellationToken);
        Task<ICollection<Anonymous25>> DelegatorsAsync(string pool_id, int? count, int? page, Order23? order);
        Task<ICollection<Anonymous25>> DelegatorsAsync(string pool_id, int? count, int? page, Order23? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous34>> EndpointsAsync();
        Task<ICollection<Anonymous34>> EndpointsAsync(CancellationToken cancellationToken);
        Task<Epoch_content> EpochsAsync(int number);
        Task<Epoch_content> EpochsAsync(int number, CancellationToken cancellationToken);
        Task GatewayAsync(string iPFS_path);
        Task GatewayAsync(string iPFS_path, CancellationToken cancellationToken);
        Task<Genesis_content> GenesisAsync();
        Task<Genesis_content> GenesisAsync(CancellationToken cancellationToken);
        Task<BlockContent> GetBlocksAsync(string hash_or_number);
        Task<BlockContent> GetBlocksAsync(string hash_or_number, CancellationToken cancellationToken);
        Task<Clock> GetClockAsync(CancellationToken cancellationToken);
        Task<Health> GetHealthAsync(CancellationToken cancellationToken);
        Task<BlockContent> GetLatestBlockAsync();
        Task<BlockContent> GetLatestBlockAsync(CancellationToken cancellationToken);
        Task<ICollection<BlockContent>> GetNextBlockAsync(string hash_or_number, int? count, int? page);
        Task<ICollection<BlockContent>> GetNextBlockAsync(string hash_or_number, int? count, int? page, CancellationToken cancellationToken);
        Task<BlockContent> GetSlotAsync(int slot_number, CancellationToken cancellationToken);
        Task<BlockContent> GetSlotAsync(int epoch_number, int slot_number);
        Task<BlockContent> GetSlotAsync(int epoch_number, int slot_number, CancellationToken cancellationToken);
        Task<Health> GetHealthAsync();
        Task<ICollection<Anonymous23>> History2Async(string pool_id, int? count, int? page, Order22? order);
        Task<ICollection<Anonymous23>> History2Async(string pool_id, int? count, int? page, Order22? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous28>> History3Async(string asset, int? count, int? page, Order27? order);
        Task<ICollection<Anonymous28>> History3Async(string asset, int? count, int? page, Order27? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous10>> HistoryAsync(string stake_address, int? count, int? page, Order6? order);
        Task<ICollection<Anonymous10>> HistoryAsync(string stake_address, int? count, int? page, Order6? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous18>> Labels2Async(string label, int? count, int? page, Order14? order);
        Task<ICollection<Anonymous18>> Labels2Async(string label, int? count, int? page, Order14? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous17>> LabelsAsync(int? count, int? page, Order13? order);
        Task<ICollection<Anonymous17>> LabelsAsync(int? count, int? page, Order13? order, CancellationToken cancellationToken);
        Task<Epoch_content> Latest2Async();
        Task<Epoch_content> Latest2Async(CancellationToken cancellationToken);
        Task<ICollection<Anonymous32>> ListAllAsync(int? count, int? page, Order32? order);
        Task<ICollection<Anonymous32>> ListAllAsync(int? count, int? page, Order32? order, CancellationToken cancellationToken);
        Task<Response13> ListAsync(string iPFS_path);
        Task<Response13> ListAsync(string iPFS_path, CancellationToken cancellationToken);
        Task<ICollection<Anonymous7>> MetadataAllAsync(string hash);
        Task<ICollection<Anonymous7>> MetadataAllAsync(string hash, CancellationToken cancellationToken);
        Task<Response10> MetadataAsync(string pool_id);
        Task<Response10> MetadataAsync(string pool_id, CancellationToken cancellationToken);
        Task<ICollection<Anonymous33>> GetMetricsAsync();
        Task<ICollection<Anonymous33>> MetricsAsync(CancellationToken cancellationToken);
        Task<ICollection<Anonymous14>> Mirs2Async(string stake_address, int? count, int? page, Order10? order);
        Task<ICollection<Anonymous14>> Mirs2Async(string stake_address, int? count, int? page, Order10? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous6>> MirsAsync(string hash);
        Task<ICollection<Anonymous6>> MirsAsync(string hash, CancellationToken cancellationToken);
        Task<Network> NetworkAsync();
        Task<Network> NetworkAsync(CancellationToken cancellationToken);
        Task<ICollection<Epoch_content>> Next2Async(int number, int? count, int? page);
        Task<ICollection<Epoch_content>> Next2Async(int number, int? count, int? page, CancellationToken cancellationToken);
        Task<Nutlink_address> NutlinkAsync(string address);
        Task<Nutlink_address> NutlinkAsync(string address, CancellationToken cancellationToken);
        Task<Epoch_param_content> Parameters2Async(int number);
        Task<Epoch_param_content> Parameters2Async(int number, CancellationToken cancellationToken);
        Task<Epoch_param_content> ParametersAsync();
        Task<Epoch_param_content> ParametersAsync(CancellationToken cancellationToken);
        Task<ICollection<Anonymous31>> PolicyAsync(string policy_id, int? count, int? page, Order31? order);
        Task<ICollection<Anonymous31>> PolicyAsync(string policy_id, int? count, int? page, Order31? order, CancellationToken cancellationToken);
        Task<ICollection<string>> PoolsAllAsync(int? count, int? page, Order19? order);
        Task<ICollection<string>> PoolsAllAsync(int? count, int? page, Order19? order, CancellationToken cancellationToken);
        Task<Pool> PoolsAsync(string pool_id);
        Task<Pool> PoolsAsync(string pool_id, CancellationToken cancellationToken);
        Task<ICollection<Epoch_content>> Previous2Async(int number, int? count, int? page);
        Task<ICollection<Epoch_content>> Previous2Async(int number, int? count, int? page, CancellationToken cancellationToken);
        Task<ICollection<BlockContent>> PreviousAsync(string hash_or_number, int? count, int? page);
        Task<ICollection<BlockContent>> PreviousAsync(string hash_or_number, int? count, int? page, CancellationToken cancellationToken);
        Task<ICollection<Anonymous12>> RegistrationsAsync(string stake_address, int? count, int? page, Order8? order);
        Task<ICollection<Anonymous12>> RegistrationsAsync(string stake_address, int? count, int? page, Order8? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous24>> RelaysAsync(string pool_id);
        Task<ICollection<Anonymous24>> RelaysAsync(string pool_id, CancellationToken cancellationToken);
        Task<Response14> RemoveAsync(string iPFS_path);
        Task<Response14> RemoveAsync(string iPFS_path, CancellationToken cancellationToken);
        Task<ICollection<Anonymous22>> RetiredAsync(int? count, int? page, Order20? order);
        Task<ICollection<Anonymous22>> RetiredAsync(int? count, int? page, Order20? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous22>> RetiringAsync(int? count, int? page, Order21? order);
        Task<ICollection<Anonymous22>> RetiringAsync(int? count, int? page, Order21? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous9>> RewardsAsync(string stake_address, int? count, int? page, Order5? order);
        Task<ICollection<Anonymous9>> RewardsAsync(string stake_address, int? count, int? page, Order5? order, CancellationToken cancellationToken);
        Task<BlockContent> SlotAsync(int slot_number);
        Task<ICollection<Anonymous2>> Stakes2Async(int number, string pool_id, int? count, int? page);
        Task<ICollection<Anonymous2>> Stakes2Async(int number, string pool_id, int? count, int? page, CancellationToken cancellationToken);
        Task<ICollection<Anonymous3>> Stakes3Async(string hash);
        Task<ICollection<Anonymous3>> Stakes3Async(string hash, CancellationToken cancellationToken);
        Task<ICollection<Anonymous>> StakesAsync(int number, int? count, int? page);
        Task<ICollection<Anonymous>> StakesAsync(int number, int? count, int? page, CancellationToken cancellationToken);
        Task<string> SubmitAsync(ContentType content_Type);
        Task<string> SubmitAsync(ContentType content_Type, CancellationToken cancellationToken);
        Task<ICollection<Anonymous36>> Tickers2Async(string address, string ticker, int? count, int? page, Order34? order);
        Task<ICollection<Anonymous36>> Tickers2Async(string address, string ticker, int? count, int? page, Order34? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous37>> Tickers3Async(string ticker, int? count, int? page, Order35? order);
        Task<ICollection<Anonymous37>> Tickers3Async(string ticker, int? count, int? page, Order35? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous35>> TickersAsync(string address, int? count, int? page, Order33? order);
        Task<ICollection<Anonymous35>> TickersAsync(string address, int? count, int? page, Order33? order, CancellationToken cancellationToken);
        Task<Address_content_total> TotalAsync(string address);
        Task<Address_content_total> TotalAsync(string address, CancellationToken cancellationToken);
        Task<ICollection<Anonymous29>> Transactions2Async(string asset, int? count, int? page, Order29? order);
        Task<ICollection<Anonymous29>> Transactions2Async(string asset, int? count, int? page, Order29? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous21>> TransactionsAsync(string address, int? count, int? page, Order18? order, string from, string to);
        Task<ICollection<Anonymous21>> TransactionsAsync(string address, int? count, int? page, Order18? order, string from, string to, CancellationToken cancellationToken);
        Task<ICollection<string>> TxsAll2Async(string hash_or_number, int? count, int? page, Order2? order);
        Task<ICollection<string>> TxsAll2Async(string hash_or_number, int? count, int? page, Order2? order, CancellationToken cancellationToken);
        Task<ICollection<string>> TxsAll3Async(string address, int? count, int? page, Order17? order);
        Task<ICollection<string>> TxsAll3Async(string address, int? count, int? page, Order17? order, CancellationToken cancellationToken);
        Task<ICollection<string>> TxsAll4Async(string asset, int? count, int? page, Order28? order);
        Task<ICollection<string>> TxsAll4Async(string asset, int? count, int? page, Order28? order, CancellationToken cancellationToken);
        Task<ICollection<string>> TxsAllAsync(int? count, int? page, Order? order);
        Task<ICollection<string>> TxsAllAsync(int? count, int? page, Order? order, CancellationToken cancellationToken);
        Task<Tx_content> TxsAsync(string hash);
        Task<Tx_content> TxsAsync(string hash, CancellationToken cancellationToken);
        Task<ICollection<Anonymous26>> UpdatesAsync(string pool_id, int? count, int? page, Order25? order);
        Task<ICollection<Anonymous26>> UpdatesAsync(string pool_id, int? count, int? page, Order25? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous20>> UtxosAllAsync(string address, int? count, int? page, Order16? order);
        Task<ICollection<Anonymous20>> UtxosAllAsync(string address, int? count, int? page, Order16? order, CancellationToken cancellationToken);
        Task<Tx_content_utxo> UtxosAsync(string hash);
        Task<Tx_content_utxo> UtxosAsync(string hash, CancellationToken cancellationToken);
        Task<ICollection<Anonymous13>> Withdrawals2Async(string stake_address, int? count, int? page, Order9? order);
        Task<ICollection<Anonymous13>> Withdrawals2Async(string stake_address, int? count, int? page, Order9? order, CancellationToken cancellationToken);
        Task<ICollection<Anonymous5>> WithdrawalsAsync(string hash);
        Task<ICollection<Anonymous5>> WithdrawalsAsync(string hash, CancellationToken cancellationToken);
    }
}