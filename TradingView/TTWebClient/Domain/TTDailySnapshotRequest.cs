using System;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Daily account snapshot request
    /// </summary>
    public class TTDailySnapshotRequest
    {
        /// <summary>Lower timestamp bound of the daily account snapshot request (optional)</summary>
        public DateTime? TimestampFrom { get; set; }

        /// <summary>Upper timestamp bound of the daily account snapshot request (optional)</summary>
        public DateTime? TimestampTo { get; set; }

        /// <summary>Request paging direction ("Forward" or "Backward"). Default is "Forward" (optional)</summary>
        public TTStreamingDirections? RequestDirection { get; set; }

        /// <summary>Request paging size. Default is 100 (optional)</summary>
        public int? RequestPageSize { get; set; }

        /// <summary>Request paging last Id (optional)</summary>
        public string RequestLastId { get; set; }
    }
}
