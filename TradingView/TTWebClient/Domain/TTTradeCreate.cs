using System;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Create new trade request
    /// </summary>
    public class TTTradeCreate
    {
        /// <summary>Trade client Id (optional)</summary>
        public string ClientId { get; set; }

        /// <summary>Trade type (required)</summary>
        public TTOrderTypes Type { get; set; }

        /// <summary>Trade side (required)</summary>
        public TTOrderSides Side { get; set; }

        /// <summary>Symbol (required)</summary>
        public string Symbol { get; set; }

        /// <summary>Price (optional)</summary>
        public decimal? Price { get; set; }

        /// <summary>Amount (required)</summary>
        public decimal Amount { get; set; }

        /// <summary>Stop loss (optional)</summary>
        public decimal? StopLoss { get; set; }

        /// <summary>Take profit (optional)</summary>
        public decimal? TakeProfit { get; set; }

        /// <summary>Expired timestamp (optional)</summary>
        public DateTime? Expired { get; set; }

        /// <summary>Immediate or cancel execution option (optional)</summary>
        public bool? ImmediateOrCancel { get; set; }

        /// <summary>Comment (optional)</summary>
        public string Comment { get; set; }
    }
}
