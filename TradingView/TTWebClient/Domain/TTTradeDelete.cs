using System;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Delete trade request types
    /// </summary>
    public enum TTTradeDeleteTypes
    {
        /// <summary>Cancel pending trade</summary>
        Cancel,
        /// <summary>Close position</summary>
        Close,
        /// <summary>Close one position by another position</summary>
        CloseBy
    }

    /// <summary>
    /// Trade delete result
    /// </summary>
    public class TTTradeDelete
    {
        /// <summary>Delete trade type</summary>
        public TTTradeDeleteTypes Type { get; set; }

        /// <summary>Deleted trade</summary>
        public TTTrade Trade { get; set; }

        /// <summary>By trade (optional)</summary>
        public TTTrade ByTrade { get; set; }
    }
}
