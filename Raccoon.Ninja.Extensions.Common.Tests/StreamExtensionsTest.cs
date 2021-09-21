using System.IO;
using System.Text;
using Xunit;

namespace Raccoon.Ninja.Extensions.Common.Tests
{
    public class StreamExtensionsTest
    {
        [Fact]
        public void ToMemoryStream_Success()
        {
            var text = "stream to memory stream";
            var encodedData = Encoding.UTF8.GetBytes(text);
            Stream stream = new MemoryStream(encodedData);

            var memoryStream = stream.ToMemoryStream();
            Assert.Equal(stream.Length, memoryStream.Length);
        }
    }
}