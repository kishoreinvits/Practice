namespace DesignPrinciples.SOLID._3.LSP.Violated
{

    public class Square : Rectangle
    {
        public override int Width
        {
            get => base.Width;
            set => base.Width = base.Height = value;
        }

        public override int Height
        {
            get => base.Height;
            set => base.Height = base.Width = value;
        }
    }

}
