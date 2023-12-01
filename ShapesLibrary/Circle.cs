using ShapesLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary
{
    /// <summary>
    /// Represents a circle, with a radius and the ability to calculate its area.
    /// </summary>
    /// <remarks>
    /// This class extends the <see cref="Shape"/> class.
    /// </remarks>
    public class Circle : Shape
    {
        /// <summary>
        /// Resresent a radius of circle
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Circle"/> class with the specified radius.
        /// </summary>
        /// <param name="radius">The radius of the circle.</param>
        /// <exception cref="ArgumentException">Thrown when the radius is less than 0.</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("The radius cannot be less than 0");
            Radius = radius;
        }

        /// <summary>
        /// Calculates the area of the circle using the formula A = π * r^2.
        /// </summary>
        /// <returns>The area of the circle.</returns>
        public override double CalculateArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
