using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._3.LSP.Valid
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
