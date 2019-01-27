namespace TTWebClient.Domain
{
    /// <summary>
    /// Currency information
    /// </summary>
    public class TTCurrency
    {
        /// <summary>Currency name</summary>
        public string Name { get; set; }

        /// <summary>Currency precision (digits after decimal point)</summary>
        public int Precision { get; set; }

        /// <summary>Currency description</summary>
        public string Description { get; set; }
    }
}
