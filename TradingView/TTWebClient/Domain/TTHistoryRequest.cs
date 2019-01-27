using System;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Streaming directions
    /// </summary>
    public enum TTStreamingDirections
    {
        Forward,
        Backward
    }    
    
    /// <summary>
    /// Trade history request
    /// </summary>
    public class TTTradeHistoryRequest
    {
        /// <summary>Lower timestamp bound of the trade history request (optional)</summary>
        public DateTime? TimestampFrom { get; set; }

        /// <summary>Upper timestamp bound of the trade history request (optional)</summary>
        public DateTime? TimestampTo { get; set; }

        /// <summary>OrderId to filter the trade history request (optional)</summary>
        public long? OrderId { get; set; }

        /// <summary>Skip canel order history records (optional)</summary>
        public bool? SkipCancelOrder { get; set; }

        /// <summary>Request paging direction ("Forward" or "Backward"). Default is "Forward" (optional)</summary>
        public TTStreamingDirections? RequestDirection { get; set; }

        /// <summary>Request paging size. Default is 100 (optional)</summary>
        public int? RequestPageSize { get; set; }

        /// <summary>Request paging last Id (optional)</summary>
        public string RequestLastId { get; set; }
    }
}
