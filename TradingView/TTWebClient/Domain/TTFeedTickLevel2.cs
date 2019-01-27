using System;
using System.Collections.Generic;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Feed tick 
    /// </summary>
    public class TTFeedTickLevel2
    {
        /// <summary>Symbol name</summary>
        public string Symbol { get; set; }

        /// <summary>Timestamp</summary>
        public DateTime Timestamp { get; set; }

        /// <summary>Best bid value</summary>
        public TTFeedLevel2Record BestBid { get; set; }

        /// <summary>Best ask value</summary>
        public TTFeedLevel2Record BestAsk { get; set; }

        /// <summary>Bid book</summary>
        public List<TTFeedLevel2Record> Bids { get; set; }

        /// <summary>Ask book</summary>
        public List<TTFeedLevel2Record> Asks { get; set; }
    }
}
