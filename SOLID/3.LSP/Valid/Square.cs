namespace DesignPrinciples.SOLID._3.LSP.Valid
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
