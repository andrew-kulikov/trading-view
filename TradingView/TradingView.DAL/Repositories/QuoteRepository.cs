using System;
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

		public IQueryable<Quote> GetRange(long from, long to) => _context.Quotes.Where(q => q.Timestamp >= from && q.Timestamp <= to);

		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
