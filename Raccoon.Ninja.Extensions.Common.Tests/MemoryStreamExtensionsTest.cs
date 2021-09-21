using System.IO;
using System.Text;
using Xunit;

namespace Raccoon.Ninja.Extensions.Common.Tests
{
    public class MemoryStreamExtensionsTest
    {
        [Fact]
        public void ToUtf8String_Success()
        {
            var text = "memory stream to utf8 string";
            var encodedData = Encoding.UTF8.GetBytes(text);
            var memoryStream = new MemoryStream(encodedData);

            var convertedMemoryStream = memoryStream.ToUtf8String();
            Assert.Equal(text, convertedMemoryStream);
        }
    }
}