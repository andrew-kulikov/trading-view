using System.Web.Http;

namespace TradingView.Api.Controllers
{
	public class QuotesController : ApiController
	{
		[Authorize]
		[Route("api/quotes")]
		public IHttpActionResult Get()
		{
			return Ok("Quotes");
		}
	}

}