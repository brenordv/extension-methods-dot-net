using System;
using Raccoon.Ninja.Extensions.Common.Internationalization;

namespace Raccoon.Ninja.Extensions.Common
{
    /// <summary>
    /// Extension methods for DateTime instances
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        ///     Creates a new DateTime object, based on current, with time values adjusted.
        /// </summary>
        /// <param name="dt">Current DateTime object</param>
        /// <param name="hour">If informed, will override HOUR</param>
        /// <param name="minute">If informed, will override MINUTE</param>
        /// <param name="second">If informed, will override SECONDS</param>
        /// <param name="ms">If informed, will override MILLISECOND</param>
        /// <returns>New datetime object with adjusted time.</returns>
        public static DateTime AdjustTime(
            this DateTime dt,
            int? hour = null, int? minute = null, int? second = null, int? ms = null)
        {
            try
            {
                return new DateTime(
                    dt.Year,
                    dt.Month,
                    dt.Day,
                    hour ?? dt.Hour,
                    minute ?? dt.Minute,
                    second ?? dt.Second,
                    ms ?? dt.Millisecond,
                    dt.Kind
                );
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentException(ErrorMessages.InvalidDateManipulation, e);
            }
        }

        /// <summary>
        ///     Creates a new DateTime object, based on current, with date values adjusted.
        /// </summary>
        /// <param name="dt">Current DateTime object</param>
        /// <param name="year">If informed, will override YEAR</param>
        /// <param name="month">If informed, will override MONTH</param>
        /// <param name="day">If informed, will override DAY</param>
        /// <returns>New datetime object with adjusted date.</returns>
        public static DateTime AdjustDate(
            this DateTime dt,
            int? year = null, int? month = null, int? day = null)
        {
            try
            {
                return new DateTime(
                    year ?? dt.Year,
                    month ?? dt.Month,
                    day ?? dt.Day,
                    dt.Hour,
                    dt.Minute,
                    dt.Second,
                    dt.Millisecond,
                    dt.Kind
                );
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new ArgumentException(ErrorMessages.InvalidDateManipulation, e);
            }
        }

        /// <summary>
        ///     Returns a new DateTime object pointing to the start of the minute.
        ///     (zero seconds and zero milliseconds passed)
        ///     Ie: 2021-02-02 12:59:34.123 -> 2021-02-02 12:59:00.000
        /// </summary>
        /// <param name="dt">Current DateTime object</param>
        /// <returns>New datetime object with adjusted time.</returns>
        public static DateTime AdjustToMinuteStart(this DateTime dt)
        {
            return dt.AdjustTime(second: 0, ms: 0);
        }

        /// <summary>
        ///     Returns a new DateTime object pointing to the end of the minute.
        ///     (59 seconds and 999 milliseconds passed)
        ///     Ie: 2021-02-02 12:59:34.123 -> 2021-02-02 12:59:59.999
        /// </summary>
        /// <param name="dt">Current DateTime object</param>
        /// <returns>New datetime object with adjusted time.</returns>
        public static DateTime AdjustToMinuteEnd(this DateTime dt)
        {
            return dt.AdjustTime(second: 59, ms: 999);
        }

        /// <summary>
        ///     Checks if some other date object has the same values for the Date.
        /// </summary>
        /// <param name="dt">Current DateTime object</param>
        /// <param name="otherDate">object to be compared with.</param>
        /// <returns>true if it's the same day/false otherwise.</returns>
        public static bool IsSameDate(this DateTime dt, DateTime otherDate)
        {
            return dt.Date.Equals(otherDate.Date);
        }

        /// <summary>
        ///     Checks if the hour in the datetime corresponds to Midnight (0 hour).
        ///     This checks ignores anything after hours (minutes, seconds, ms, etc.)
        /// </summary>
        /// <param name="dt">Current DateTime</param>
        /// <param name="utcOffset">if current date is in utc, this offset will be used in the calculation. Default: 180 (BRT-3)</param>
        /// <returns>true if it's midnight. false otherwise</returns>
        public static bool IsMidnight(this DateTime dt, int utcOffset = 180)
        {
            if (dt.Kind != DateTimeKind.Utc)
                return dt.Hour == 0;

            var (year, month, day) = (dt.Year, dt.Month, dt.Day);
            return dt.AddMinutes(-utcOffset).Hour == 0
                   && dt.Year == year
                   && dt.Month == month
                   && dt.Day == day;
        }

        /// <summary>
        /// Checks if date is today
        /// </summary>
        /// <param name="dt">datetime to check</param>
        /// <returns>true if is today</returns>
        public static bool IsToday(this DateTime dt)
        {
            if (dt.Kind != DateTimeKind.Utc)
                return DateTime.Now.Date == dt.Date;

            return DateTime.UtcNow.Date == dt.Date;
        }

        /// <summary>
        /// Checks if date is today and hour is equal to current hour
        /// </summary>
        /// <param name="dt">datetime to check</param>
        /// <returns>true if is today and hour equal to current hour</returns>
        public static bool IsTodaySameHour(this DateTime dt)
        {
            if (dt.Kind != DateTimeKind.Utc)
                return dt.IsToday() && DateTime.Now.Hour == dt.Hour;

            return dt.IsToday() && DateTime.UtcNow.Hour == dt.Hour;
        }
    }
}