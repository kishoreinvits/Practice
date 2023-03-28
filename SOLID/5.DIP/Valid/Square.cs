namespace SOLID._5.DIP.Valid
{
    public class Square : IShape
    {
        public int SideLength { get; set; }

        public int CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

}
