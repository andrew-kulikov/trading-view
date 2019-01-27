using System.Collections.Generic;

namespace TTWebClient.Domain
{
	public class TTBars
	{
		public long From { get; set; }
		public long To { get; set; }
		public string Symbol { get; set; }
		public long AvailableFrom { get; set; }
		public long AvailableTo { get; set; }
		public string LastTickId { get; set; }


		public List<TTBar> Bars { get; set; }
	}
}
