using System;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Feed tick 
    /// </summary>
    public class TTFeedTick
    {
        /// <summary>Symbol name</summary>
        public string Symbol { get; set; }

        /// <summary>Timestamp</summary>
        public DateTime Timestamp { get; set; }

        /// <summary>Best bid value</summary>
        public TTFeedLevel2Record BestBid { get; set; }

        /// <summary>Best ask value</summary>
        public TTFeedLevel2Record BestAsk { get; set; }
    }
}
