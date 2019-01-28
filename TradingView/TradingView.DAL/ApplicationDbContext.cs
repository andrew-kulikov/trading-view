using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;
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

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Quote>()
				.HasKey(q => q.Id)
				.Property(q => q.Id)
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			base.OnModelCreating(modelBuilder);
		}
	}
}