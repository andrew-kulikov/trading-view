using System.Web.Http;

namespace TradingView.Api.Controllers
{
	[RoutePrefix("api/Orders")]
	public class OrdersController : ApiController
	{
		[Authorize]
		[Route("")]
		public IHttpActionResult Get()
		{
			return Ok();
		}
	}

}