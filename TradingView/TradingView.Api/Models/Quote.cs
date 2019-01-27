namespace TradingView.Api.Models
{
	public class Quote
	{
		public string Id { get; set; }

		public Symbol Symbol { get; set; }
		public int SymbolId { get; set; }

		public long Timestamp { get; set; }
		public float Open { get; set; }
		public float High { get; set; }
		public float Low { get; set; }
		public float Close { get; set; }
		public float Volume { get; set; }
	}
}