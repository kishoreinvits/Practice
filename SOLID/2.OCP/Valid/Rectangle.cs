namespace DesignPrinciples.SOLID._2.OCP.Valid
{
    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override int CalculateArea()
        {
            return Width * Height;
        }
    }

}
