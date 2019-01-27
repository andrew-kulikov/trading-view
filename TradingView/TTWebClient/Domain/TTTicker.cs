using System;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Symbol ticker information
    /// </summary>
    public class TTTicker
    {
        /// <summary>Symbol name</summary>
        public string Symbol { get; set; }

        /// <summary>Best bid</summary>
        public decimal BestBid { get; set; }

        /// <summary>Best ask</summary>
        public decimal BestAsk { get; set; }

        /// <summary>Last buy price</summary>
        public decimal LastBuyPrice { get; set; }

        /// <summary>Last buy volume</summary>
        public decimal LastBuyVolume { get; set; }

        /// <summary>Last buy timestamp</summary>
        public DateTime LastBuyTimestamp { get; set; }

        /// <summary>Last sell price</summary>
        public decimal LastSellPrice { get; set; }

        /// <summary>Last sell volume</summary>
        public decimal LastSellVolume { get; set; }

        /// <summary>Last sell timestamp</summary>
        public DateTime LastSellTimestamp { get; set; }

        /// <summary>Daily best buy price</summary>
        public decimal DailyBestBuyPrice { get; set; }

        /// <summary>Daily best sell price</summary>
        public decimal DailyBestSellPrice { get; set; }

        /// <summary>Daily traded buy volume</summary>
        public decimal DailyTradedBuyVolume { get; set; }

        /// <summary>Daily traded sell volume</summary>
        public decimal DailyTradedSellVolume { get; set; }

        /// <summary>Daily traded total volume</summary>
        public decimal DailyTradedTotalVolume { get; set; }
    }
}
