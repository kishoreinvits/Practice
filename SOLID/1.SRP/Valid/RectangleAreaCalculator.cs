namespace DesignPrinciples.SOLID._1.SRP.Valid
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
