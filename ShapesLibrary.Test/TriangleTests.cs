using NUnit.Framework;

namespace ShapesLibrary.Test
{
    class TriangleTests
    {
        [TestCase(3, 4, 5, ExpectedResult = 6)]
        [TestCase(5, 12, 13, ExpectedResult = 30)]
        [TestCase(8, 15, 17, ExpectedResult = 60)]
        [TestCase(7, 24, 25, ExpectedResult = 84)]
        public double CalculateArea_RightAngledTriangle(double side1, double side2, double side3)
        {
            // Arrange
            var triangle = new Triangle(side1, side2, side3);

            // Act
            return triangle.CalculateArea();
        }

        [TestCase(4, 4, 4, ExpectedResult = 6.928203230275509)]
        [TestCase(6, 8, 10, ExpectedResult = 24)]
        [TestCase(9, 12, 15, ExpectedResult = 54)]
        public double CalculateArea_NonRightAngledTriangle(double side1, double side2, double side3)
        {
            // Arrange
            var triangle = new Triangle(side1, side2, side3);

            // Act
            return triangle.CalculateArea();
        }

        [Test]
        public void TriangleInitialization_InvalidSideLengths_ThrowsArgumentException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(-1, 2, 3));
        }

        [Test]
        public void TriangleInitialization_InvalidTriangleInequality_ThrowsArgumentException()
        {
            // Arrange, Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5));
        }

        [Test]
        public void IsTriangler_RightAngledTriangle_ReturnsTrue()
        {
            // Arrange
            var triangle = new Triangle(3, 4, 5);

            // Act & Assert
            Assert.IsTrue(triangle.IsTriangler);
        }

        [Test]
        public void IsTriangler_NonRightAngledTriangle_ReturnsFalse()
        {
            // Arrange
            var triangle = new Triangle(1, 2, 3);

            // Act & Assert
            Assert.IsFalse(triangle.IsTriangler);
        }
    }
}
