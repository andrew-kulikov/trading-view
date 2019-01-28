using System;

namespace TradingView.Utils.Helpers
{
	public static class TimeHelper
	{
		private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		public static DateTime TimeStampToDateTime(double timestamp) =>
			Epoch.AddSeconds(timestamp).ToLocalTime();

		public static long ConvertToTimestamp(DateTime value)
		{
			var elapsedTime = value - Epoch;
			return (long)elapsedTime.TotalSeconds;
		}

		public static long GetTomorow()
		{
			var tomorrow = DateTime.Now.AddDays(1);
			var tomorrowNight = new DateTime(tomorrow.Year, tomorrow.Month, tomorrow.Day, 0, 0, 0, DateTimeKind.Utc);
			return ConvertToTimestamp(tomorrowNight);
		}
	}
}
