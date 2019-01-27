using System;

namespace TTWebClient.Domain
{
    /// <summary>
    /// Margin calculation modes
    /// </summary>
    public enum TTMarginCalculationModes
    {
        Forex,
        CFD,
        Futures,
        CFD_Index,
        CFD_Leverage
    }

    /// <summary>
    /// Profit calculation modes
    /// </summary>
    public enum TTProfitCalculationModes
    {
        Forex,
        CFD,
        Futures,
        CFD_Index,
        CFD_Leverage
    }

    /// <summary>
    /// Commission value type
    /// </summary>
    public enum TTCommissionValueType
    {
        Money,
        Points,
        Percentage
    }

    /// <summary>
    /// Commission charge type
    /// </summary>
    public enum TTCommissionChargeType
    {
        PerLot, 
        PerDeal 
    }

    /// <summary>
    /// Commission charge method
    /// </summary>
    public enum TTCommissionChargeMethod
    {
        OneWay,
        RoundTurn
    }

    /// <summary>
    /// Symbol information
    /// </summary>
    public class TTSymbol
    {
        /// <summary>Symbol name</summary>
        public String Symbol { get; set; }

        /// <summary>Symbol precision (digits after decimal point)</summary>
        public int Precision { get; set; }

        /// <summary>Is trade allowed for the symbol?</summary>
        public bool IsTradeAllowed { get; set; }

        /// <summary>Margin calculation mode</summary>
        public TTMarginCalculationModes MarginMode { get; set; }

        /// <summary>Profit calculation mode</summary>
        public TTProfitCalculationModes ProfitMode { get; set; }

        /// <summary>Contract size for the symbol</summary>
        public double ContractSize { get; set; }

        /// <summary>The factor which is used to calculate margin for hedged orders/positions</summary>
        public double MarginHedged { get; set; }

        /// <summary>The factor of margin calculation</summary>
        public double MarginFactor { get; set; }

        /// <summary>Margin currency name</summary>
        public string MarginCurrency { get; set; }

        /// <summary>Margin currency precision</summary>
        public int MarginCurrencyPrecision { get; set; }

        /// <summary>Profit currency name</summary>
        public string ProfitCurrency { get; set; }

        /// <summary>Profit currency precision</summary>
        public int ProfitCurrencyPrecision { get; set; }

        /// <summary>Symbol description</summary>
        public string Description { get; set; }

        /// <summary>Is swap enabled for the symbol?</summary>
        public bool SwapEnabled { get; set; }

        /// <summary>Short swap size</summary>
        public float SwapSizeShort { get; set; }

        /// <summary>Long swap size</summary>
        public float SwapSizeLong { get; set; }
	
        /// <summary>Minimal trade amount</summary>
        public decimal MinTradeAmount { get; set; }

        /// <summary>Maximal trade amount</summary>
        public decimal MaxTradeAmount { get; set; }

        /// <summary>Trade amount step</summary>
        public decimal TradeAmountStep { get; set; }

        /// <summary>Commission type</summary>
        public TTCommissionValueType CommissionType { get; set; }

        /// <summary>Commission charge type</summary>
        public TTCommissionChargeType CommissionChargeType { get; set; }

        /// <summary>Commission charge method</summary>
        public TTCommissionChargeMethod CommissionChargeMethod { get; set; }

        /// <summary>Commission</summary>
        public decimal Commission { get; set; }

        /// <summary>Limits commission</summary>
        public decimal LimitsCommission { get; set; }	
    }
}
