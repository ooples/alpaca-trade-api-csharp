﻿using System;
using System.Diagnostics.CodeAnalysis;

namespace Alpaca.Markets
{
    /// <summary>
    /// Encapsulates basic bar information for Alpaca APIs.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedMemberInSuper.Global")]
    [CLSCompliant(false)]
    public interface IBar
    {
        /// <summary>
        /// Gets asset name.
        /// </summary>
        String Symbol { get; }

        /// <summary>
        /// Gets the beginning time of this bar in the UTC.
        /// </summary>
        DateTime TimeUtc { get; }

        /// <summary>
        /// Gets bar open price.
        /// </summary>
        Decimal Open { get; }

        /// <summary>
        /// Gets bar high price.
        /// </summary>
        Decimal High { get; }

        /// <summary>
        /// Gets bar low price.
        /// </summary>
        Decimal Low { get; }

        /// <summary>
        /// Gets bar close price.
        /// </summary>
        Decimal Close { get; }

        /// <summary>
        /// Gets bar trading volume.
        /// </summary>
        UInt64 Volume { get; }
    }
}