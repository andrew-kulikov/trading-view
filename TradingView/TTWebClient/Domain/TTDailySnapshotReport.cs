using System;
using System.Collections.Generic;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Daily account snapshot
    /// </summary>
    public class TTDailySnapshot
    {
        /// <summary>Account snapshot Id</summary>
        public long AccountId { get; set; }

        /// <summary>Account snapshot timestamp</summary>
        public DateTime Timestamp { get; set; }

        /// <summary>Account snapshot group</summary>
        public string Group { get; set; }

        /// <summary>Account snapshot type</summary>
        public TTAccountingTypes AccountingType { get; set; }

        /// <summary>Account snapshot leverage</summary>
        public int Leverage { get; set; }

        /// <summary>Account snapshot balance</summary>
        public decimal Balance { get; set; }

        /// <summary>Account snapshot balance currency</summary>
        public string BalanceCurrency { get; set; }

        /// <summary>Account snapshot profit</summary>
        public decimal Profit { get; set; }

        /// <summary>Account snapshot commission</summary>
        public decimal Commission { get; set; }

        /// <summary>Account snapshot agent commission</summary>
        public decimal AgentCommission { get; set; }

        /// <summary>Account snapshot total commission</summary>
        public decimal TotalCommission => Commission + AgentCommission;

        /// <summary>Account snapshot swap</summary>
        public decimal Swap { get; set; }

        /// <summary>Account snapshot total profit loss</summary>
        public decimal TotalProfitLoss => Profit + TotalCommission + Swap;

        /// <summary>Account snapshot equity</summary>
        public decimal Equity { get; set; }

        /// <summary>Account snapshot margin</summary>
        public decimal Margin { get; set; }

        /// <summary>Account snapshot margin level</summary>
        public decimal MarginLevel { get; set; }

        /// <summary>Account snapshot blocked flag</summary>
        public bool IsBlocked { get; set; }

        /// <summary>Account snapshot readonly flag</summary>
        public bool IsReadonly { get; set; }

        /// <summary>Account snapshot valid flag</summary>
        public bool IsValid { get; set; }

        /// <summary>Account snapshot assets</summary>
        public List<TTAsset> Assets { get; set; }

        /// <summary>Account snapshot positions</summary>
        public List<TTPosition> Positions { get; set; }

        /// <summary>Account snapshot balance to USD conversion rate</summary>
        public decimal? BalanceToUsdConversionRate { get; set; }

        /// <summary>Account snapshot USD to balance conversion rate</summary>
        public decimal? UsdToBalanceConversionRate { get; set; }

        /// <summary>Account snapshot profit to USD conversion rate</summary>
        public decimal? ProfitToUsdConversionRate { get; set; }

        /// <summary>Account snapshot USD to profit conversion rate</summary>
        public decimal? UsdToProfitConversionRate { get; set; }
    }

    /// <summary>
    /// Daily account snapshot report
    /// </summary>
    public class TTDailySnapshotReport
    {
        /// <summary>Is report last for paging request?</summary>
        public bool IsLastReport { get; set; }

        /// <summary>Count of total reports</summary>
        public long TotalReports { get; set; }

        /// <summary>List of daily account snapshot records</summary>
        public List<TTDailySnapshot> Records { get; set; }

        /// <summary>Last daily account snapshot record Id (used for paging)</summary>
        public string LastId { get; set; }
    }
}
