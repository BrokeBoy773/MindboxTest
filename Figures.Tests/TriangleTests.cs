using Xunit;

namespace Figures.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(0, 2, 5)]
        [InlineData(2, 0, 4)]
        [InlineData(6, 2, 0)]
        [InlineData(0, 0, 0)]
        public void CalculateAreaByThreeSides_With0_ReturnsMinus1(double a, double b, double c)
        {
            double result = Triangle.CalculateAreaByThreeSides(a, b, c);

            Assert.Equal(-1, result);
        }

        [Fact]
        public void CalculateAreaByThreeSides_WithNaN_ReturnsMinus1()
        {
            double a = 2;
            double b = 3;
            double c = 10;

            double result = Triangle.CalculateAreaByThreeSides(a, b, c);

            Assert.Equal(-1, result);
        }
    }
}
