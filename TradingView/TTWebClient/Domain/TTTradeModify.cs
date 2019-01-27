using System;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Modify trade request
    /// </summary>
    public class TTTradeModify
    {
        /// <summary>Trade Id (required)</summary>
        public long Id { get; set; }

        /// <summary>Price (optional)</summary>
        public decimal? Price { get; set; }

        /// <summary>Stop loss (optional)</summary>
        public decimal? StopLoss { get; set; }

        /// <summary>Take profit (optional)</summary>
        public decimal? TakeProfit { get; set; }

        /// <summary>Expired timestamp (optional)</summary>
        public DateTime? Expired { get; set; }

        /// <summary>Comment (optional)</summary>
        public string Comment { get; set; }
    }
}
