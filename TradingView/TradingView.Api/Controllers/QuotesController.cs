using Newtonsoft.Json;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using TradingView.DAL.Repositories;

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
			[FromUri] string exchange = null, [FromUri] int? limit = null)
		{
			using (var symbolRepository = new SymbolRepository())
			{
				var foundSymbols = symbolRepository
					.FindByName(query)
					.Take(limit ?? 30)
					.ToList();

				if (foundSymbols.Count == 0)
				{
					return NotFound();
				}

				return Ok(foundSymbols.Select(s => new { symbol = s.Name, full_name = s.Name }));
			}
		}
	}

}