using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Valid
{

    public class RectangleAreaCalculator : IRectangleAreaCalculator
    {
        public int CalculateArea(Rectangle rectangle)
        {
            // calculate area of rectangle
            return rectangle.Height * rectangle.Width;
        }
    }

}
