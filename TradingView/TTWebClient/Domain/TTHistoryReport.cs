using System;
using System.Collections.Generic;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Trade transaction types
    /// </summary>
    public enum TTTradeTransTypes
    {
        OrderOpened     = 0,
        OrderCanceled   = 1,
        OrderExpired    = 2,
        OrderFilled     = 3,
        PositionClosed  = 4,
        Balance         = 5,
        Credit          = 6,
        PositionOpened  = 7,
        OrderActivated  = 8
    }

    /// <summary>
    /// Trade transaction reasons
    /// </summary>
    public enum TTTradeTransReasons
    {
        ClientRequest   = 0,
        PndOrdAct       = 1,
        StopOut         = 2,
        StopLossAct     = 3,
        TakeProfitAct   = 4,
        DealerDecision  = 5,
        Rollover        = 6,
        Delete          = 7,
        Expired         = 8
    }

    /// <summary>
    /// Trade history record
    /// </summary>
    public class TTTradeHistory
    {
        /// <summary>Trade history record Id</summary>
        public string Id { get; set; }

        /// <summary>Trade transaction type</summary>
        public TTTradeTransTypes TransactionType { get; set; }

        /// <summary>Trade transaction reason</summary>
        public TTTradeTransReasons TransactionReason { get; set; }

        /// <summary>Trade transaction timestamp</summary>
        public DateTime TransactionTimestamp { get; set; }

        /// <summary>Symbol</summary>
        public string Symbol { get; set; }

        /// <summary>Symbol precision</summary>
        public int? SymbolPrecision { get; set; }

        /// <summary>Trade Id</summary>
        public long TradeId { get; set; }

        /// <summary>Parent trade Id</summary>
        public long? ParentTradeId { get; set; }

        /// <summary>Client trade Id</summary>
        public string ClientTradeId { get; set; }

        /// <summary>Trade side</summary>
        public TTOrderSides? TradeSide { get; set; }

        /// <summary>Trade type</summary>
        public TTOrderTypes? TradeType { get; set; }

        /// <summary>Trade created timestamp</summary>
        public DateTime? TradeCreated { get; set; }

        /// <summary>Trade modified timestamp</summary>
        public DateTime? TradeModified { get; set; }

        /// <summary>Trade amount</summary>
        public decimal? TradeAmount { get; set; }

        /// <summary>Trade max visible amount</summary>
        public decimal? TradeMaxVisibleAmount { get; set; }

        /// <summary>Trade hidden amount</summary>
        public decimal? TradeHiddenAmount { get; set; }

        /// <summary>Trade initial amount</summary>
        public decimal? TradeInitialAmount { get; set; }

        /// <summary>Trade last fill amount</summary>
        public decimal? TradeLastFillAmount { get; set; }

        /// <summary>Trade price</summary>
        public decimal? TradePrice { get; set; }

        /// <summary>Trade fill price</summary>
        public decimal? TradeFillPrice { get; set; }

        /// <summary>Request price</summary>
        public decimal? RequestPrice { get; set; }

        /// <summary>Request timestamp</summary>
        public DateTime? RequestTimestamp { get; set; }

        /// <summary>Request open price</summary>
        public decimal? RequestOpenPrice { get; set; }

        /// <summary>Request open amount</summary>
        public decimal? RequestOpenAmount { get; set; }

        /// <summary>Request close price</summary>
        public decimal? RequestClosePrice { get; set; }

        /// <summary>Request close amount</summary>
        public decimal? RequestCloseAmount { get; set; }

        /// <summary>Position Id</summary>
        public long? PositionId { get; set; }

        /// <summary>Position by Id</summary>
        public long? PositionById { get; set; }

        /// <summary>Position amount</summary>
        public decimal? PositionAmount { get; set; }

        /// <summary>Position initial amount</summary>
        public decimal? PositionInitialAmount { get; set; }

        /// <summary>Position last amount</summary>
        public decimal? PositionLastAmount { get; set; }

        /// <summary>Position open price</summary>
        public decimal? PositionOpenPrice { get; set; }

        /// <summary>Position opened timestamp</summary>
        public DateTime? PositionOpened { get; set; }

        /// <summary>Position close price</summary>
        public decimal? PositionClosePrice { get; set; }

        /// <summary>Position closed timestamp</summary>
        public DateTime? PositionClosed { get; set; }

        /// <summary>Balance value</summary>
        public decimal? Balance { get; set; }

        /// <summary>Balance movement value</summary>
        public decimal? BalanceMovement { get; set; }

        /// <summary>Balance currency</summary>
        public string BalanceCurrency { get; set; }

        /// <summary>Stop loss</summary>
        public decimal? StopLoss { get; set; }

        /// <summary>Take profit</summary>
        public decimal? TakeProfit { get; set; }

        /// <summary>Commission</summary>
        public decimal? Commission { get; set; }

        /// <summary>Agent commission</summary>
        public decimal? AgentCommission { get; set; }

        /// <summary>Reduced Open Commission Flag</summary>
        public bool? ReducedOpenCommissionFlag { get; set; }

        /// <summary>Reduced Close Commission Flag</summary>
        public bool? ReducedCloseCommissionFlag { get; set; }

        /// <summary>Minimal Commission Currency</summary>
        public string MinCommissionCurrency { get; set; }

        /// <summary>Minimal Commission Conversion Rate</summary>
        public decimal? MinCommissionConversionRate { get; set; }

        /// <summary>Swap</summary>
        public decimal? Swap { get; set; }

        /// <summary>Immediate-Or-Cancel flag</summary>
        public bool ImmediateOrCancel { get; set; }

        /// <summary>Market-With-Slippage flag</summary>
        public bool MarketWithSlippage { get; set; }

        /// <summary>Expired timestamp</summary>
        public DateTime? Expired { get; set; }

        /// <summary>Time of described position modification.</summary>
        public DateTime? PosModified { get; set; }

        /// <summary>Comment</summary>
        public string Comment { get; set; }

        /// <summary>Initial margin rate</summary>
        public decimal? MarginRateInitial { get; set; }

        /// <summary>Open conversion rate</summary>
        public decimal? OpenConversionRate { get; set; }

        /// <summary>Close conversion rate</summary>
        public decimal? CloseConversionRate { get; set; }

        /// <summary>Conversion rate to convert profit to USD</summary>
        public decimal? ProfitToUsdConversionRate { get; set; }

        /// <summary>Conversion rate to convert USD to profit currency</summary>
        public decimal? UsdToProfitConversionRate { get; set; }

        /// <summary>Conversion rate to convert balance currency to USD</summary>
        public decimal? BalanceToUsdConversionRate { get; set; }

        /// <summary>Conversion rate to convert USD to balance currency</summary>
        public decimal? UsdToBalanceConversionRate { get; set; }

        /// <summary>Conversion rate to convert margin currency to USD</summary>
        public decimal? MarginCurrencyToUsdConversionRate { get; set; }

        /// <summary>Conversion rate to convert USD to margin currency</summary>
        public decimal? UsdToMarginCurrencyConversionRate { get; set; }

        /// <summary>Margin currency</summary>
        public string MarginCurrency { get; set; }

        /// <summary>Conversion rate to convert profit currency to USD</summary>
        public decimal? ProfitCurrencyToUsdConversionRate { get; set; }

        /// <summary>Conversion rate to convert USD to profit currency</summary>
        public decimal? UsdToProfitCurrencyConversionRate { get; set; }

        /// <summary>Profit currency</summary>
        public string ProfitCurrency { get; set; }

        /// <summary>Conversion rate to convert source asset currency to USD</summary>
        public decimal? SrcAssetToUsdConversionRate { get; set; }

        /// <summary>Conversion rate to convert USD to source asset currency</summary>
        public decimal? UsdToSrcAssetConversionRate { get; set; }

        /// <summary>Conversion rate to convert destination asset currency to USD</summary>
        public decimal? DstAssetToUsdConversionRate { get; set; }

        /// <summary>Conversion rate to convert USD to destination asset currency</summary>
        public decimal? UsdToDstAssetConversionRate { get; set; }

        /// <summary>Source asset currency</summary>
        public string SrcAssetCurrency { get; set; }

        /// <summary>Source asset final amount</summary>
        public decimal? SrcAssetAmount { get; set; }

        /// <summary>Amount on which source asset was changed during described transaction</summary>
        public decimal? SrcAssetMovement { get; set; }

        /// <summary>Destination asset currency</summary>
        public string DstAssetCurrency { get; set; }

        /// <summary>Destination asset final amount</summary>
        public decimal? DstAssetAmount { get; set; }

        /// <summary>Amount on which destinaction asset was changed during described transaction</summary>
        public decimal? DstAssetMovement { get; set; }

        /// <summary>Client appliction</summary>
        public string ClientApp { get; set; }
    }

    /// <summary>
    /// Trade history report
    /// </summary>
    public class TTTradeHistoryReport
    {
        /// <summary>Is report last for paging request?</summary>
        public bool IsLastReport { get; set; }

        /// <summary>Count of total reports</summary>
        public long TotalReports { get; set; }

        /// <summary>List of trade history records</summary>
        public List<TTTradeHistory> Records { get; set; }

        /// <summary>Last trade history record Id (used for paging)</summary>
        public string LastId { get; set; }
    }
}
