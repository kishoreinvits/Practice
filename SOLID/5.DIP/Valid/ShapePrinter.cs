namespace SOLID._5.DIP.Valid
{
    public class ShapePrinter
    {
        public void PrintArea(IShape shape)
        {
            Console.WriteLine($"The area of the shape is {shape.CalculateArea()}");
        }
    }

}
