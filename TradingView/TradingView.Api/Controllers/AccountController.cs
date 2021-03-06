﻿using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using TradingView.DAL.Models;
using TradingView.DAL.Repositories;

namespace TradingView.Api.Controllers
{
	[RoutePrefix("api/Account")]
	public class AccountController : ApiController
	{
		private AuthRepository _repo = null;

		public AccountController()
		{
			_repo = new AuthRepository();
		}

		// POST api/Account/Register
		[AllowAnonymous]
		[Route("Register")]
		public async Task<IHttpActionResult> Register(UserRegisterModel userRegisterModel)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			IdentityResult result = await _repo.RegisterUser(userRegisterModel);

			IHttpActionResult errorResult = GetErrorResult(result);

			return errorResult ?? Ok();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				_repo.Dispose();
			}

			base.Dispose(disposing);
		}

		private IHttpActionResult GetErrorResult(IdentityResult result)
		{
			if (result == null)
			{
				return InternalServerError();
			}

			if (!result.Succeeded)
			{
				if (result.Errors != null)
				{
					foreach (string error in result.Errors)
					{
						ModelState.AddModelError("", error);
					}
				}

				if (ModelState.IsValid)
				{
					// No ModelState errors are available to send, so just return an empty BadRequest.
					return BadRequest();
				}

				return BadRequest(ModelState);
			}

			return null;
		}
	}
}