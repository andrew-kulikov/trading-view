namespace TTWebClient.Domain
{
    /// <summary>
    /// Price type
    /// </summary>
    public enum TTPriceType
    {
        Bid = 0,
        Ask = 1
    }

    /// <summary>
    /// Feed Level 2 record
    /// </summary>
    public class TTFeedLevel2Record
    {
        /// <summary>Price type</summary>
        public TTPriceType Type { get; set; }

        /// <summary>Price</summary>
        public decimal Price { get; set; }

        /// <summary>Volume</summary>
        public decimal Volume { get; set; }
    }
}
