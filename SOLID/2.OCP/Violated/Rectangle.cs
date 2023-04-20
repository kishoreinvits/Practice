namespace DesignPrinciples.SOLID._2.OCP.Violated
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }

}
