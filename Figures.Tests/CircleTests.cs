using Xunit;

namespace Figures.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateAreaFromRadius_With0_ReturnsMinus1()
        {
            double radius = 0;

            double result = Circle.CalculateAreaFromRadius(radius);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void CalculateAreaFromRadius_WithNegativeNumber_ReturnsMinus1()
        {
            double radius = -10;

            double result = Circle.CalculateAreaFromRadius(radius);

            Assert.Equal(-1, result);
        }
    }
}
