using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Raccoon.Ninja.Extensions.Common.Internationalization;

namespace Raccoon.Ninja.Extensions.Common
{
    /// <summary>
    /// Extension methods for string instances
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     Regex pattern that will seek one or more spaces, tabs and line breaks.
        /// </summary>
        private static readonly Regex BreakLinePattern = new Regex(@"(\s+|\t+|\r+|\n+)");

        /// <summary>
        ///     Converts a string to a Memory stream, encoding the bytes using UTF-8.
        /// </summary>
        /// <param name="data">string to be encoded.</param>
        /// <returns>memory stream representing the encoded string.</returns>
        public static MemoryStream ToMemoryStream(this string data)
        {
            if (string.IsNullOrWhiteSpace(data))
                throw new ArgumentException(ErrorMessages.NullStringToConvert);
            
            var encodedData = Encoding.UTF8.GetBytes(data);
            var stream = new MemoryStream(encodedData);
            stream.Seek(0, SeekOrigin.Begin);

            return stream;
        }

        /// <summary>
        ///     Minifies a text.
        ///     Replaces everything that is caught by the Pattern variable and replaces it with one space.
        ///     If null or empty, will return null.
        /// </summary>
        /// <param name="bigText">Text to be minified.</param>
        /// <returns>Minified text.</returns>
        public static string Minify(this string bigText)
        {
            return string.IsNullOrWhiteSpace(bigText)
                ? bigText
                : BreakLinePattern.Replace(bigText, " ");
        }

        /// <summary>
        ///     Remove accents... well, actually, remove all DIACRITICS from a string,
        ///     but saying 'accents' is easier to remember.
        /// </summary>
        /// <param name="text">Text that will be used to remove diacritics</param>
        /// <returns>Text without diacritics</returns>
        public static string StripAccents(this string text)
        {
            var stFormD = text.Normalize(NormalizationForm.FormD);
            var sb = new StringBuilder();

            foreach (var t in stFormD)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(t);
                if (uc == UnicodeCategory.NonSpacingMark) continue;
                sb.Append(t);
            }

            return sb.ToString().Normalize(NormalizationForm.FormC);
        }

        /// <summary>
        ///     Removes everything that's not a digit (0 through 9) from a string.
        /// </summary>
        /// <param name="text">target string</param>
        /// <returns>string containing only numbers</returns>
        public static string OnlyDigits(this string text)
        {
            return Regex.Replace(text, "[^0-9]", "");
        }
    }
}
