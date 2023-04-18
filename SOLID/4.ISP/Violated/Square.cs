namespace DesignPrinciples.SOLID._4.ISP.Violated
{
    public class Square : IShape
    {
        public int SideLength { get; set; }

        public int CalculateArea()
        {
            return SideLength * SideLength;
        }

        public int GetWidth()
        {
            return SideLength;
        }

        public int GetHeight()
        {
            return SideLength;
        }
    }

}
