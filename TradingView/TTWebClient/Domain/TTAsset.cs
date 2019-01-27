namespace TTWebClient.Domain
{
    /// <summary>
    /// Asset information
    /// </summary>
    public class TTAsset
    {
        /// <summary>Asset currency</summary>
        public string Currency { get; set; }

        /// <summary>Asset amount</summary>
        public decimal Amount { get; set; }
    }
}
