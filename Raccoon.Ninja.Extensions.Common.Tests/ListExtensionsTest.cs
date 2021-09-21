using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using Xunit;

namespace Raccoon.Ninja.Extensions.Common.Tests
{
    public class ListExtensionsTest
    {
        [Fact]
        public void ForEachWithIndex_Success()
        {
            var strings = new List<string>
            {
                "test1",
                "test2",
                "test3"
            };

            var stringsWithIndex = strings.ForEachWithIndex();

            Assert.IsAssignableFrom<IEnumerable<(int, string)>>(stringsWithIndex);
            Assert.NotEmpty(stringsWithIndex);
            Assert.Equal(3, stringsWithIndex.Count());
            Assert.Collection(stringsWithIndex,
                item => Assert.Equal(strings[item.index], item.item),
                item => Assert.Equal(strings[item.index], item.item),
                item => Assert.Equal(strings[item.index], item.item));
        }

        [Fact]
        public void ContainsCaseInsensitive_Success_false()
        {
            new List<List<string>> { null, new List<string>() }
                .ForEach(l => Assert.False(l.ContainsCaseInsensitive("foo")
                    )
                );
        }
        
        [Theory]
        [InlineData("")]
        [InlineData("     ")]
        [InlineData(null)]
        public void ContainsCaseInsensitive_Success_EmptyContains(string contains)
        {
            var list = new List<string> { "foo", "bar" };
            Assert.False(list.ContainsCaseInsensitive(contains));
        }
        
        
        [Theory]
        [InlineData("Foo")]
        [InlineData("FOO")]
        [InlineData("foo")]
        [InlineData("fOo")]
        [InlineData("foO")]
        public void ContainsCaseInsensitive_Success(string contains)
        {
            var list = new List<string> { "foo", "bar" };
            Assert.True(list.ContainsCaseInsensitive(contains));
        }
        
        [Theory]
        [InlineData("Foo")]
        [InlineData("FOO")]
        [InlineData("foo")]
        [InlineData("fOo")]
        [InlineData("foO")]
        public void ContainsCaseInsensitive_Success2(string contains)
        {
            var list = new List<string> { "foo", "bar" }.AsReadOnly();
            Assert.True(list.ContainsCaseInsensitive(contains));
        }

        [Fact]
        public void Replace_Success_TrueString()
        {
            const string toBeReplaced = "foo";
            const string toReplaceWith = "bar";

            var list = new List<string> { "foo", "x", "apple", "bacon" };
            Assert.True(list.Replace(toBeReplaced, toReplaceWith));
            Assert.Equal(toReplaceWith, list[0]);
        }
        
        
        [Fact]
        public void Replace_Success_TrueObj()
        {
            var toBeReplaced = new { foo="foo"};
            var toReplaceWith = new { foo="bar"};;

            var list = new List<dynamic> { new { foo="foo"}, new { foo="x"}, new { foo="bar"}, new { foo="bacon"} };
            Assert.True(list.Replace(toBeReplaced, toReplaceWith));
            Assert.Equal(toReplaceWith, list[0]);
        }
        
        [Fact]
        public void Replace_Success_NotFound()
        {
            const string toBeReplaced = "apples";
            const string toReplaceWith = "oranges";

            var list = new List<string> { "foo", "x", "apple", "bacon" };
            Assert.False(list.Replace(toBeReplaced, toReplaceWith));
            
        }
    }
}