using System.Collections.Generic;

namespace TTWebClient.Domain
{
	public class TTCacheTicks
	{
		/// <summary>Symbol name</summary>
		public string Symbol { get; set; }

		public List<TTFeedTick> Ticks { get; set; }
	}
}
