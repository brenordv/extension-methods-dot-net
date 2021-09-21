using System;

namespace Raccoon.Ninja.Extensions.Common
{
    /// <summary>
    /// Extension methods for TimeSpan instances
    /// </summary>
    public static class TimeSpanExtensions
    {
        private const int RoundLimit = 500;

        /// <summary>
        ///     If the TimeSpan object has milliseconds equal to or greater than 5000000 (half second)
        ///     it will be rounded up. Otherwise, will be rounded down.
        /// </summary>
        /// <param name="ts">TimeSpan object to be checked</param>
        /// <returns>rounded TimeSpan object</returns>
        public static TimeSpan RoundMs(this TimeSpan ts)
        {
            
            var tsRoundedDown = new TimeSpan(ts.Days, ts.Hours, ts.Minutes, ts.Seconds, 0);
            return ts.Milliseconds >= RoundLimit
                ? tsRoundedDown.Add(TimeSpan.FromSeconds(1))
                : tsRoundedDown;
        }
    }
}