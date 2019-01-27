using Microsoft.AspNet.Identity.EntityFramework;
namespace TradingView.DAL
{
	public class ApplicationDbContext : IdentityDbContext<IdentityUser>
	{

		public ApplicationDbContext()
			: base("ApplicationDbContext")
		{

		}
	}
}