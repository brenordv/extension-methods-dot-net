using System;
using Xunit;

namespace Raccoon.Ninja.Extensions.Common.Tests
{
    public class TimeSpanExtensionsTest
    {
        [Theory]
        [InlineData("0.00:00:00.5")]
        [InlineData("0.00:00:00.51")]
        [InlineData("0.00:00:00.6")]
        [InlineData("0.00:00:00.500001")]
        public void RoundMs_Success_Up(string timeStamp)
        {
            var ts = TimeSpan.Parse(timeStamp);
            var expectedTs = TimeSpan.FromSeconds(1);
            Assert.Equal(expectedTs, ts.RoundMs());
            
        }
        
        [Theory]
        [InlineData("0.00:00:00.4")]
        [InlineData("0.00:00:00.4999999")]
        [InlineData("0.00:00:00.1")]
        [InlineData("0.00:00:00.00001")]
        public void RoundMs_Success_Down(string timeStamp)
        {
            var ts = TimeSpan.Parse(timeStamp);
            var expectedTs = TimeSpan.FromSeconds(0);
            Assert.Equal(expectedTs, ts.RoundMs());
            
        }
    }
}