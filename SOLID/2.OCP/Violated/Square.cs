namespace DesignPrinciples.SOLID._2.OCP.Violated
{
    public class Square : Rectangle
    {
        public new int Width
        {
            get => base.Width;
            set => base.Width = base.Height = value;
        }

        public new int Height
        {
            get => base.Height;
            set => base.Height = base.Width = value;
        }
    }

}
