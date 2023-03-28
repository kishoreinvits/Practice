namespace SOLID.SRP.Valid
{
    public class RectanglePerimeterCalculator : IRectanglePerimeterCalculator
    {
        public int CalculatePerimeter(Rectangle rectangle)
        {
            // calculate perimeter of rectangle
            return 2 * (rectangle.Height + rectangle.Width);
        }
    }

}
