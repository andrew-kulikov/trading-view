using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Threading.Tasks;
using TradingView.DAL.Models;

namespace TradingView.DAL.Repositories
{
	public class AuthRepository : IDisposable
	{
		private readonly ApplicationDbContext _ctx;

		private readonly UserManager<IdentityUser> _userManager;

		public AuthRepository()
		{
			_ctx = new ApplicationDbContext();
			_userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(_ctx));
		}

		public async Task<IdentityResult> RegisterUser(UserRegisterModel userRegisterModel)
		{
			var user = new IdentityUser
			{
				UserName = userRegisterModel.UserName
			};

			var result = await _userManager.CreateAsync(user, userRegisterModel.Password);

			return result;
		}

		public async Task<IdentityUser> FindUser(string userName, string password)
		{
			IdentityUser user = await _userManager.FindAsync(userName, password);

			return user;
		}

		public void Dispose()
		{
			_ctx.Dispose();
			_userManager.Dispose();
		}
	}
}