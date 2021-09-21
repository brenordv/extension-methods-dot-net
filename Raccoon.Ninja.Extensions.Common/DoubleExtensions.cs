using System;

namespace Raccoon.Ninja.Extensions.Common
{
    /// <summary>
    /// Extension methods for double instances
    /// </summary>
    public static class DoubleExtensions
    {
        /// <summary>
        ///     Convenience method to return a rounded version of a double.
        /// </summary>
        /// <param name="value">value to round</param>
        /// <param name="digits">lenght of decimal places</param>
        /// <returns>value rounded</returns>
        public static double Round(this double value, int digits)
        {
            return Math.Round(value, digits, MidpointRounding.AwayFromZero);
        }
    }
}