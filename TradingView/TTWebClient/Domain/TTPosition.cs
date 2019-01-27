namespace TTWebClient.Domain
{
    /// <summary>
    /// Position information
    /// </summary>
    public class TTPosition
    {
        /// <summary>Position Id</summary>
        public long Id { get; set; }	

        /// <summary>Position symbol</summary>
        public string Symbol { get; set; }

        /// <summary>Position long (buy) amount</summary>
        public decimal LongAmount { get; set; }

        /// <summary>Position long (buy) price</summary>
        public decimal LongPrice { get; set; }

        /// <summary>Position short (sell) amount</summary>
        public decimal ShortAmount { get; set; }

        /// <summary>Position short (sell) price</summary>
        public decimal ShortPrice { get; set; }

        /// <summary>Commission</summary>
        public decimal? Commission { get; set; }

        /// <summary>Agent commission</summary>
        public decimal? AgentCommission { get; set; }

        /// <summary>Swap</summary>
        public decimal? Swap { get; set; }
    }
}
