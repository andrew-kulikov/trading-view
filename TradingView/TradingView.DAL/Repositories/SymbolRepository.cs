using System;
using System.Linq;
using System.Threading.Tasks;
using TradingView.DAL.Models;

namespace TradingView.DAL.Repositories
{
	public class SymbolRepository : IDisposable
	{
		private readonly ApplicationDbContext _context;


		public SymbolRepository()
		{
			_context = new ApplicationDbContext();
		}

		public async Task AddSymbol(Symbol symbol)
		{
			_context.Symbols.Add(symbol);
			await _context.SaveChangesAsync();
		}

		public IQueryable<Symbol> GetAll() => _context.Symbols;

		public IQueryable<Symbol> FindByName(string pattern) => 
			_context.Symbols.Where(s => s.Name.ToLower().Contains(pattern.ToLower()));


		public void Dispose()
		{
			_context.Dispose();
		}
	}
}
