using ShapesLibrary.Abstract;

namespace ShapesLibrary
{
    /// <summary>
    /// Represents a triangle, a specific type of shape, with three sides and the ability to calculate its area.
    /// </summary>
    /// <remarks>
    /// This class extends the <see cref="Shape"/> class.
    /// </remarks>
    public class Triangle : Shape
    {
        /// <summary>
        /// Gets the length of side AB of the triangle.
        /// </summary>
        /// <value>The length of side AB.</value>
        public double AB { get; private set; }
        /// <summary>
        /// Gets the length of side BC of the triangle.
        /// </summary>
        /// <value>The length of side BC.</value>
        public double BC { get; private set; }
        /// <summary>
        /// Gets the length of side AC of the triangle.
        /// </summary>
        /// <value>The length of side AC.</value>
        public double AC { get; private set; }
        /// <summary>
        /// Gets a value indicating whether the triangle satisfies the Triangle Inequality.
        /// </summary>
        /// <value><c>true</c> if the triangle is valid; otherwise, <c>false</c>.</value>
        public bool IsTriangler { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class with given side lengths.
        /// </summary>
        /// <param name="firstSide">The length of the first side.</param>
        /// <param name="secondSide">The length of the second side.</param>
        /// <param name="thirdSide">The length of the third side.</param>
        /// <exception cref="ArgumentException">Thrown when any of the side lengths is less than 0 or violates the Triangle Inequality.</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
                throw new ArgumentException("One of the sides is less than 0");
            var sortedSides = new double[] { firstSide, secondSide, thirdSide };
            Array.Sort(sortedSides);
            AC = sortedSides[0];
            BC = sortedSides[1];
            AB = sortedSides[2];
            // Check if the triangle satisfies the Triangle Inequality
            if (AB > AC + BC)
                throw new ArgumentException("The sum of the two sides is less than the third party. This violates the Triangle Inequality.");
            IsTriangler = Math.Pow(AB, 2) == Math.Pow(BC, 2) + Math.Pow(AC, 2);
        }

        /// <summary>
        /// Calculates the area of the triangle.
        /// </summary>
        /// <returns>The area of the triangle.</returns>
        public override double CalculateArea()
        {
            double square;
            if (IsTriangler)
                square = (AC * BC) / 2;
            else
            {
                // Calculate the area using Heron's formula for non-right-angled triangles
                var perimetr = (AB + AC + BC) / 2;
                square = Math.Sqrt(perimetr * (perimetr - AC) * (perimetr - AB) * (perimetr - BC));
            }
            return square;
        }
    }
}
