﻿using System;

namespace Alpaca.Markets
{
    /// <summary>
    /// 
    /// </summary>
    public static class LiveEnvironment
    {
        /// <summary>
        /// 
        /// </summary>
        public static Uri TradingApiUrl { get; } = new Uri("https://api.alpaca.markets");

        /// <summary>
        /// 
        /// </summary>
        public static Uri PolygonApiUrl { get; } = new Uri("wss://alpaca.socket.polygon.io/stocks");
    }
}
