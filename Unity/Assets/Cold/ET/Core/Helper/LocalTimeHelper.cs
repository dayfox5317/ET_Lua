using System;

namespace ETCold
{
	public static class LocalTimeHelper
	{
		private static readonly long epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).Ticks;

		public static long CurrentTicks()
		{
			return DateTime.UtcNow.Ticks - epoch;
		}

		public static long CurrentMilliseconds()
		{
			return CurrentTicks() / 10000;
		}

		public static long CurrentSeconds()
		{
			return CurrentMilliseconds() / 1000;
		}
    }
}