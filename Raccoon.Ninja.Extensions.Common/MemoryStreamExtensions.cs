using System.IO;
using System.Text;

namespace Raccoon.Ninja.Extensions.Common
{
    /// <summary>
    /// Extension methods for MemoryStream instances
    /// </summary>
    public static class MemoryStreamExtensions
    {
        /// <summary>
        /// Converts a memory stream to an utf-8 encoded string.
        /// </summary>
        /// <param name="stream">stream to be converted</param>
        /// <returns>converted string</returns>
        public static string ToUtf8String(this MemoryStream stream)
        {
            return Encoding.UTF8.GetString(stream.ToArray());
        }
    }
}