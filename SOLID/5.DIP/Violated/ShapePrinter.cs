namespace DesignPrinciples.SOLID._5.DIP.Violated
{
    public class ShapePrinter
    {
        public void PrintArea(Rectangle rectangle)
        {
            Console.WriteLine($"The area of the rectangle is {rectangle.Width * rectangle.Height}");
        }

        public void PrintArea(Square square)
        {
            Console.WriteLine($"The area of the square is {square.SideLength * square.SideLength}");
        }
    }
}
