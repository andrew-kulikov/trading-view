using System.Web.Http;
using Newtonsoft.Json;

namespace TradingView.Api.Controllers
{
	[RoutePrefix("api")]
	public class QuotesController : ApiController
	{
		[Route("config")]
		[HttpGet]
		public IHttpActionResult GetConfig()
		{
			return Ok(JsonConvert.SerializeObject(new
			{
				supported_resolutions = new[] { "1", "5", "15", "30", "60", "1D", "1W", "1M" },
				supports_group_request = false,
				supports_marks = false,
				supports_search = true,
				supports_timescale_marks = false
			}));
		}

		[Route("search")]
		[HttpGet]
		public IHttpActionResult FindSymbols(
			[FromUri] string query = null, [FromUri] string type = null,
			[FromUri] string exchange = null, [FromUri] string limit = null)
		{
			return Json(new[]
			{
				new Symbol
				{
					symbol = "A",
					full_name = "A",
					description = "sdf",
					exchange = "sdfsdf",
					type = "kek"

				},
				new Symbol
				{
					symbol = "B",
					full_name = "B",
					description = "sdf",
					exchange = "sdfsdf",
					type = "kek"
				},
				new Symbol
				{
					symbol = "C",
					full_name = "C",
					description = "sdf",
					exchange = "sdfsdf",
					type = "kek"
				},
			});
		}


	}

	internal class Symbol
	{
		public string symbol { get; set; }
		public string description { get; set; }
		public string exchange { get; set; }
		public string full_name { get; set; }
		public string type { get; set; }
	}

}