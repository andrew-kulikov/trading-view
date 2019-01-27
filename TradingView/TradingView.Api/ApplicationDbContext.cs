using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TradingView.Api.Models;

namespace TradingView.Api
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{
		public DbSet<Quote> Quotes { get; set; }
		public DbSet<Symbol> Symbols { get; set; }

		public ApplicationDbContext()
			: base("ApplicationDbContext")
		{

		}
	}
}