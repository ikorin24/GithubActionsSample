using Xunit;
using GithubActionsSample;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AddTest()
        {
            Assert.Equal(3, SampleLibrary.Add(1, 2));
        }
    }
}
