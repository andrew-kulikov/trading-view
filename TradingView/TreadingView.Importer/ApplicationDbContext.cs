using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TradingView.DAL.Models;

namespace TradingView.DAL
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