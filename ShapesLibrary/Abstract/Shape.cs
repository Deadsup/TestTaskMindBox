using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesLibrary.Abstract
{
    /// <summary>
    /// Represents an abstract class for geometric shapes.
    /// </summary>
    /// <remarks>
    /// This abstract class serves as a base class for various geometric shapes and enforces the implementation of the CalculateArea method.
    /// </remarks>
    public abstract class Shape
    {
        /// <summary>
        /// Calculates and returns the area of the specific geometric shape.
        /// </summary>
        /// <returns>The area of the geometric shape.</returns>
        public abstract double CalculateArea();
    }
}
