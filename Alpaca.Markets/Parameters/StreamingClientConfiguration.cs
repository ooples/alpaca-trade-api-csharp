﻿namespace Alpaca.Markets;

/// <summary>
/// Configuration parameters object for <see cref="StreamingClientBase{TConfiguration}"/> class.
/// </summary>
[SuppressMessage("ReSharper", "PropertyCanBeMadeInitOnly.Global")]
public abstract class StreamingClientConfiguration
{
    /// <summary>
    /// Creates new instance of <see cref="StreamingClientConfiguration"/> class.
    /// </summary>
    protected internal StreamingClientConfiguration(Uri apiEndpoint)
    {
        SecurityId = new SecretKey(String.Empty, String.Empty);
        ApiEndpoint = apiEndpoint;
    }

    /// <summary>
    /// Gets or sets Alpaca streaming API base URL.
    /// </summary>
    public Uri ApiEndpoint { get; set; }

    /// <summary>
    /// Gets or sets Alpaca secret key identifier.
    /// </summary>
    public SecurityKey SecurityId { get; set; }

    internal virtual Uri GetApiEndpoint() => ApiEndpoint;

    internal void EnsureIsValid()
    {
        ApiEndpoint.EnsurePropertyNotNull();
        SecurityId.EnsurePropertyNotNull();
    }
}
