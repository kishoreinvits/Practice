namespace SOLID._4.ISP.Valid
{
    public class Square : IHasArea, IHasDimensions
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
