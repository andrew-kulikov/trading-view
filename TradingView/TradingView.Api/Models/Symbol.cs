using System.ComponentModel.DataAnnotations;

namespace TradingView.Api.Models
{
	public class Symbol
	{
		public int Id { get; set; }

		[Required]
		[StringLength(20)]
		public string Name { get; set; }
	}
}