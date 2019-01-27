using System.Web.Http;

namespace TradingView.Api.Controllers
{
	[RoutePrefix("api")]
	public class QuotesController : ApiController
	{

		[HttpGet]
		[Route("config")]
		public IHttpActionResult GetConfig()
		{
			return Ok(new
			{
				supported_resolutions = new[] { "1", "5", "15", "30", "60", "1D", "1W", "1M" },
				supports_group_request = false,
				supports_marks = false,
				supports_search = true,
				supports_timescale_marks = false
			});
		}

		[HttpGet]
		[Route("search")]
		public IHttpActionResult FindSymbols(
			[FromUri] string query, [FromUri] string type, 
			[FromUri] string exchange, [FromUri] string limit)
		{
			return Ok(new[]
			{
				new Symbol
				{
					symbol = "A"
				},
				new Symbol
				{
					symbol = "B"
				},
				new Symbol
				{
					symbol = "C"
				},
			});
		}


	}

	class Symbol
	{
		public string symbol { get; set; }
		public string description { get; set; }
		public string exchange { get; set; }
		public string full_name { get; set; }
		public string type { get; set; }
	}

}