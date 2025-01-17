﻿namespace Alpaca.Markets;

/// <summary>
/// Provides unified type-safe access for Alpaca Crypto Data API via HTTP/REST.
/// </summary>
[CLSCompliant(false)]
public interface IAlpacaCryptoDataClient :
    IHistoricalQuotesClient<HistoricalCryptoQuotesRequest>,
    IHistoricalTradesClient<HistoricalCryptoTradesRequest>,
    IHistoricalBarsClient<HistoricalCryptoBarsRequest>,
    IDisposable
{
    /// <summary>
    /// Gets last bar for singe asset from Alpaca REST API endpoint.
    /// </summary>
    /// <param name="request">Asset name and exchange pair for data retrieval.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Read-only last bar information.</returns>
    [UsedImplicitly]
    Task<IBar> GetLatestBarAsync(
        LatestDataRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets last bar for several assets from Alpaca REST API endpoint.
    /// </summary>
    /// <param name="request">Asset names list and exchange pair for data retrieval.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Read-only dictionary with the last bars information.</returns>
    [UsedImplicitly]
    Task<IReadOnlyDictionary<String,IBar>> ListLatestBarsAsync(
        LatestDataListRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets last trade for singe asset from Alpaca REST API endpoint.
    /// </summary>
    /// <param name="request">Asset name and exchange pair for data retrieval.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Read-only last trade information.</returns>
    [UsedImplicitly]
    Task<ITrade> GetLatestTradeAsync(
        LatestDataRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets last trade for several assets from Alpaca REST API endpoint.
    /// </summary>
    /// <param name="request">Asset names list and exchange pair for data retrieval.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Read-only dictionary with the last trades information.</returns>
    [UsedImplicitly]
    Task<IReadOnlyDictionary<String,ITrade>> ListLatestTradesAsync(
        LatestDataListRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets current quote for singe asset from Alpaca REST API endpoint.
    /// </summary>
    /// <param name="request">Asset name and exchange pair for data retrieval.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Read-only current quote information.</returns>
    [UsedImplicitly]
    Task<IQuote> GetLatestQuoteAsync(
        LatestDataRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets last quote for several assets from Alpaca REST API endpoint.
    /// </summary>
    /// <param name="request">Asset names list and exchange pair for data retrieval.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Read-only dictionary with the last quotes information.</returns>
    [UsedImplicitly]
    Task<IReadOnlyDictionary<String,IQuote>> ListLatestQuotesAsync(
        LatestDataListRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets current cross-exchange best bid/offer (XBBO) for singe asset from Alpaca REST API endpoint.
    /// </summary>
    /// <param name="request">Asset name and exchanges list pair for data retrieval.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Read-only current XBBO information.</returns>
    [UsedImplicitly]
    Task<IQuote> GetLatestBestBidOfferAsync(
        LatestBestBidOfferRequest request,
        CancellationToken cancellationToken = default);
    
    /// <summary>
    /// Gets current cross-exchange best bid/offer (XBBO) for several assets from Alpaca REST API endpoint.
    /// </summary>
    /// <param name="request">Asset name and exchanges list pair for data retrieval.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Read-only dictionary with the current XBBO information.</returns>
    [UsedImplicitly]
    Task<IReadOnlyDictionary<String, IQuote>> ListLatestBestBidOffersAsync(
        LatestBestBidOfferListRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets current snapshot data for singe asset from Alpaca REST API endpoint.
    /// </summary>
    /// <param name="request">Asset name and exchange pair for data retrieval.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Read-only current snapshot information.</returns>
    [UsedImplicitly]
    Task<ISnapshot> GetSnapshotAsync(
        SnapshotDataRequest request,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets current snapshot data for several assets from Alpaca REST API endpoint.
    /// </summary>
    /// <param name="request">Asset name and exchange pair for data retrieval.</param>
    /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
    /// <returns>Read-only dictionary with the current snapshot information.</returns>
    [UsedImplicitly]
    Task<IReadOnlyDictionary<String,ISnapshot>> ListSnapshotsAsync(
        SnapshotDataListRequest request,
        CancellationToken cancellationToken = default);
}
