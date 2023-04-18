﻿namespace DesignPrinciples.SOLID._3.LSP.Violated
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }

}
