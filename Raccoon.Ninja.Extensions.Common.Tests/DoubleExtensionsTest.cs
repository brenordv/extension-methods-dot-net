using Xunit;

namespace Raccoon.Ninja.Extensions.Common.Tests
{
    public class DoubleExtensionsTest
    {
        [Theory]
        [InlineData(5.99, 6, 1)]
        [InlineData(5.89, 5.9, 1)]
        [InlineData(2.8556, 2.86, 2)]
        [InlineData(2.8556, 2.856, 3)]
        [InlineData(2.8556, 2.8556, 4)]
        [InlineData(2.8556, 2.8556, 5)]
        public void Round_Success(double value, double expected, int digits)
        {
            Assert.Equal(expected, value.Round(digits));
        }
    }
}