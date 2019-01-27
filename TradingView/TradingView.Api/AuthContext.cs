using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using TradingView.Api.Models;

namespace TradingView.Api
{
	public class AuthContext : IdentityDbContext<IdentityUser>
	{
		public DbSet<Quote> Quotes { get; set; }
		public DbSet<Symbol> Symbols { get; set; }

		public AuthContext()
			: base("AuthContext")
		{

		}
	}
}