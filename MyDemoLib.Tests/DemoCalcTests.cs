using System.Threading.Tasks;
using Xunit;

namespace MyDemoLib.Tests
{
    public sealed class DemoCalcTests
    {
        [Fact]
        public async Task ComputeThree_ShouldReturn_3()
        {
            DemoCalc calc = new DemoCalc();

            int expected = await ReadExpectedAsync();
            int actual = calc.ComputeThree();

            Assert.Equal(expected, actual);
        }

        private Task<int> ReadExpectedAsync() => Task.FromResult(3);
    }
}
