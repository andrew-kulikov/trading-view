using System;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using TradingView.DAL.Models;
using TradingView.DAL.Repositories;
using TTWebClient;

namespace TreadingView.Importer
{
	internal class Program
	{
		private const int BatchSize = 300;
		private static void Main(string[] args)
		{
			var webApiAddress = "https://ttdemowebapi.soft-fx.com:8443";
			var webApiId = "1de621ca-e686-4ee2-92a5-45c87b4b3fe5";
			var webApiKey = "czNhCcnK6ydePCHZ";
			var webApiSecret = "J6Jxc2xPr8JyNpWtyEaCPYpkpJpsSQ38xb9AZNxBAGdtQrNDhQwf9mkWQygCKd6K";

			TickTraderWebClient.IgnoreServerCertificate();
			var client = new TickTraderWebClient(webApiAddress, webApiId, webApiKey, webApiSecret);

			// Uncomment to get symbols from Tick Trader Web API, Should be called 
			// before SetupQuotes method
			//SetupSymbols(client);

			// Uncomment to get last (BatchSize) bars from Web API for each symbol
			SetupQuotes(client);
		}

		public static void SetupQuotes(TickTraderWebClient client)
		{

			using (var symbolRepository = new SymbolRepository())
			using (var quoteRepository = new QuoteRepository())
			{
				var symbols = symbolRepository.GetAll().ToList();

				foreach (var symbol in symbols)
				{
					try
					{
						var periodicities = client.GetQuoteSymbolPeriodicities(symbol.Name);
						var barInfo = client.GetBarsInfo(symbol.Name, periodicities[0]);
						var bars = client.GetBars(symbol.Name, periodicities[0], 1538524800000, BatchSize);
						foreach (var bar in bars.Bars)
						{
							quoteRepository.AddQuote(new Quote
							{
								SymbolId = symbol.Id,
								Timestamp = bar.Timestamp,
								Close = bar.Close,
								High = bar.High,
								Low = bar.Low,
								Open = bar.Open,
								Volume = bar.Open
							});
						}
					}
					catch (HttpRequestException e)
					{
						Console.WriteLine(e.Message);
					}
					catch (SqlException e)
					{
						Console.WriteLine(e.Message);
					}
				}
			}

		}

		public static void SetupSymbols(TickTraderWebClient client)
		{
			var symbols = client.GetQuoteHistorySymbols();
			foreach (var symbol in symbols)
			{
				using (var repo = new SymbolRepository())
				{
					try
					{
						repo.AddSymbol(new Symbol { Name = symbol }).GetAwaiter().GetResult();
					}
					catch (SqlException e)
					{
						Console.WriteLine(e);
					}
				}
			}
		}
	}
}
