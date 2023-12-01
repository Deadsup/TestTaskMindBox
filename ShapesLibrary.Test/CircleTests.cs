using NUnit.Framework;

namespace ShapesLibrary.Test
{
    class CircleTests
    {
        [TestCase(1, ExpectedResult = 3.141592653589793)]
        [TestCase(5, ExpectedResult = 78.539816339744830)]
        [TestCase(6, ExpectedResult = 113.097335529232556)]
        [TestCase(15, ExpectedResult = 706.858347057703478)]
        public double CalculateArea_Circle(double radius)
        {
            // Arrange
            var circle = new Circle(radius);

            // Act
            return circle.CalculateArea();
        }

        [Test]
        public void CircleInitialization_InvalidRadius_ThrowsArgumentException()
        {
            // Arrange & Act 
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }
    }
}
