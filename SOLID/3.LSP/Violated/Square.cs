using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3.LSP.Violated
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
