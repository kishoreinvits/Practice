using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SRP.Violated
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculateArea()
        {
            // calculate area of rectangle
            return Width * Height;
        }

        public int CalculatePerimeter()
        {
            // calculate perimeter of rectangle
            return 2 * (Width + Height);
        }

        public void Draw()
        {
            // draw rectangle on the screen
        }
    }
}
