using System;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Accounting types
    /// </summary>
    public enum TTAccountingTypes
    {
        Gross,
        Net,
        Cash
    }    
    
    /// <summary>
    /// Account information
    /// </summary>
    public class TTAccount
    {
        /// <summary>Account Id</summary>
        public long Id { get; set; }

        /// <summary>Account group</summary>
        public string Group { get; set; }

        /// <summary>Accounting type</summary>
        public TTAccountingTypes AccountingType { get; set; }

        /// <summary>Name</summary>
        public string Name { get; set; }

        /// <summary>Email</summary>
        public string Email { get; set; }

        /// <summary>Comment</summary>
        public string Comment { get; set; }

        /// <summary>Registered timestamp</summary>
        public DateTime Registered { get; set; }

        /// <summary>Is account blocked?</summary>
        public bool IsBlocked { get; set; }

        /// <summary>Is account read only?</summary>
        public bool IsReadonly { get; set; }

        /// <summary>Is account in valid state?</summary>
        public bool IsValid { get; set; }
	
        /// <summary>Is Web API enabled for account?</summary>
        public bool IsWebApiEnabled { get; set; }

        /// <summary>Leverage</summary>
        public int? Leverage { get; set; }

        /// <summary>Balance amount</summary>
        public decimal? Balance { get; set; }

        /// <summary>Balance currency</summary>
        public string BalanceCurrency { get; set; }

        /// <summary>Equity</summary>
        public decimal? Equity { get; set; }

        /// <summary>Margin</summary>
        public decimal? Margin { get; set; }

        /// <summary>Margin level</summary>
        public decimal? MarginLevel { get; set; }

        /// <summary>Margin call level</summary>
        public int? MarginCallLevel { get; set; }

        /// <summary>Stop out level</summary>
        public int? StopOutLevel { get; set; }
    }
}
