using MoreLinq;
using Newtonsoft.Json;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using TradingView.DAL.Repositories;
using TradingView.Utils.Helpers;

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
				supported_resolutions = new[] { "1D" },
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

		[Route("symbols")]
		[HttpGet]
		public IHttpActionResult GetSymbol([FromUri] string symbol = null)
		{
			using (var symbolRepository = new SymbolRepository())
			{
				var symbolModel = symbolRepository.FindByName(symbol).FirstOrDefault();

				if (symbolModel == null)
				{
					return NotFound();
				}

				return Ok(JsonConvert.SerializeObject(new
				{
					description = symbolModel.Name,
					name = symbolModel.Name,
					minmov = 1,
					minmov2 = 0,
					has_intraday = false,
					has_no_volume = false,
					pointvalue = 1,
					pricescale = 100,
					supported_pesolutions = new[] { "D" },
					ticker = symbolModel.Name
				}));
			}
		}

		[Route("history")]
		[HttpGet]
		public IHttpActionResult GetHistory([FromUri] long from, [FromUri] long to, [FromUri] string symbol)
		{
			using (var quoteRepository = new QuoteRepository())
			{
				var quotes = quoteRepository
					.GetSymbolRange(symbol, from, to)
					.ToList();

				if (quotes.Count == 0)
				{
					return Ok(
						JsonConvert.SerializeObject(new
						{
							status = "no_data",
							nextTime = TimeHelper.GetTomorow()
						}));
				}

				var timestamps = quotes.Select(q => q.Timestamp / 1000);
				var closing = quotes.Select(q => q.Close);
				var opening = quotes.Select(q => q.Open);
				var high = quotes.Select(q => q.High);
				var low = quotes.Select(q => q.Low);
				var volume = quotes.Select(q => q.Volume);

				return Ok(JsonConvert.SerializeObject(new
				{
					s = "ok",
					t = timestamps,
					c = closing,
					o = opening,
					h = high,
					l = low,
					v = volume
				}));
			}
		}
	}

}