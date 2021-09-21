using System.IO;

namespace Raccoon.Ninja.Extensions.Common
{
    /// <summary>
    /// Extension methods for Stream instances
    /// </summary>
    public static class StreamExtensions
    {
        /// <summary>
        /// Converts a Stream to MemoryStream
        /// </summary>
        /// <param name="stream">to be converted</param>
        /// <returns>stream converted to memory strema</returns>
        public static MemoryStream ToMemoryStream(this Stream stream)
        {
            var outputStream = new MemoryStream();
            stream.Seek(0, SeekOrigin.Begin);

            stream.CopyTo(outputStream);
            outputStream.Seek(0, SeekOrigin.Begin);

            return outputStream;
        }
    }
}