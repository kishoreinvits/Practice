namespace SOLID._2.OCP.Valid
{
    public class Square : Shape
    {
        public int SideLength { get; set; }

        public override int CalculateArea()
        {
            return SideLength * SideLength;
        }
    }

}
