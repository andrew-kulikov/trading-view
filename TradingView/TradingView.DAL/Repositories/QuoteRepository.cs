using System;
using System.Data.Entity;
using System.Linq;
using TradingView.DAL.Models;

namespace TradingView.DAL.Repositories
{
	public class QuoteRepository : IDisposable
	{
		private readonly ApplicationDbContext _context;


		public QuoteRepository()
		{
			_context = new ApplicationDbContext();
		}

		public void AddQuote(Quote quote)
		{
			_context.Quotes.Add(quote);
			_context.SaveChanges();
		}

		public IQueryable<Quote> GetAll() => _context.Quotes;

		public IQueryable<Quote> GetRange(long from, long to) =>
			_context.Quotes.Where(q => q.Timestamp >= from && q.Timestamp <= to);

		public IQueryable<Quote> GetSymbolRange(string symbol, long from, long to)
		{
			return _context.Quotes
				.Include(q => q.Symbol)
				.Where(q => q.Symbol.Name == symbol)
				.Where(q =>
					q.Timestamp / 1000 >= from &&
					q.Timestamp / 1000 <= to);
		}

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
