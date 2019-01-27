namespace TTWebClient.Domain
{
	public class TTBarsInfo
	{
		public string Symbol { get; set; }
		public long AvailableFrom { get; set; }
		public long AvailableTo { get; set; }
		public string LastTickId { get; set; }
	}
}
