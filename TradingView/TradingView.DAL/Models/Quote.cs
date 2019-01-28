using System.ComponentModel.DataAnnotations.Schema;

namespace TradingView.DAL.Models
{
	public class Quote
	{
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

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