using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TradingView.DAL.Models
{
	public class Symbol
	{
		public int Id { get; set; }

		[Required]
		[Index(IsUnique = true)]
		[StringLength(20)]
		public string Name { get; set; }
	}
}