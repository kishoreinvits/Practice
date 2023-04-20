namespace DesignPrinciples.SOLID._4.ISP.Valid
{
    public class Rectangle : IHasArea, IHasDimensions
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }

        public int GetWidth()
        {
            return Width;
        }

        public int GetHeight()
        {
            return Height;
        }
    }

}
