using Microsoft.AspNet.Identity.EntityFramework;

namespace TradingView.Api
{
	public class AuthContext : IdentityDbContext<IdentityUser>
	{
		public AuthContext()
			: base("AuthContext")
		{

		}
	}
}