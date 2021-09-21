using System;
using Raccoon.Ninja.Extensions.Common.Internationalization;
using Xunit;

namespace Raccoon.Ninja.Extensions.Common.Tests
{
    public class StringExtensionsTest
    {
        [Fact]
        public void Minify_Success()
        {
            var text = @"this is some      really      big      string
that spans through
multiple
lines";
            
            Assert.Equal(
                "this is some really big string that spans through multiple lines", 
                text.Minify());
        }
        
        [Fact]
        public void Minify_Success_AlreadyMinified()
        {
            var text = "a small text";
            
            Assert.Equal(
                "a small text", 
                text.Minify());
        }
        
        [Theory]
        [InlineData("")]
        [InlineData("             ")]
        [InlineData(null)]
        public void Minify_Success_Empty(string text)
        {
            Assert.Equal(text, text.Minify());
        }
        
        [Fact]
        public void ToMemoryStream_Success()
        {
            var text = "string to memory stream";
            var memoryStream = text.ToMemoryStream();
            Assert.NotNull(memoryStream);
            Assert.True(memoryStream.Length > 0);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void ToMemoryStream_Error(string text)
        {
            var exception = Assert.Throws<ArgumentException>(() => text.ToMemoryStream());
            Assert.Equal(ErrorMessages.NullStringToConvert, exception.Message);
        }

        [Theory]
        [InlineData("á", "a")]
        [InlineData("ã", "a")]
        [InlineData("à", "a")]
        [InlineData("â", "a")]
        [InlineData("ä", "a")]
        [InlineData("a", "a")]
        [InlineData("é", "e")]
        [InlineData("è", "e")]
        [InlineData("ê", "e")]
        [InlineData("ë", "e")]
        [InlineData("e", "e")]
        [InlineData("í", "i")]
        [InlineData("ì", "i")]
        [InlineData("ï", "i")]
        [InlineData("î", "i")]
        [InlineData("i", "i")]
        [InlineData("ó", "o")]
        [InlineData("ò", "o")]
        [InlineData("õ", "o")]
        [InlineData("ö", "o")]
        [InlineData("ô", "o")]
        [InlineData("o", "o")]
        [InlineData("ú", "u")]
        [InlineData("ù", "u")]
        [InlineData("ü", "u")]
        [InlineData("û", "u")]
        [InlineData("u", "u")]
        [InlineData("ÿ", "y")]
        [InlineData("ç", "c")]
        public void StripAccents_Success(string accented, string stripped)
        {
            Assert.Equal(stripped, accented.StripAccents());
            Assert.Equal(stripped.ToUpper(), accented.ToUpper().StripAccents());
        }

        [Theory]
        [InlineData("A1", "1")]
        [InlineData("    A1", "1")]
        [InlineData("A   1", "1")]
        [InlineData("A1    ", "1")]
        [InlineData("1", "1")]
        [InlineData("...", "")]
        [InlineData(" ", "")]
        [InlineData("ÇÁ^;/~3$#@%¨&*()!?-+§°", "3")]
        public void OnlyDigits_Success(string value, string expected)
        {
            Assert.Equal(expected, value.OnlyDigits());
        }
    }
}