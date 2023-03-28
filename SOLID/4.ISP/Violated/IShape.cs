using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._4.ISP.Violated
{
    public interface IShape
    {
        int CalculateArea();
        int GetWidth();
        int GetHeight();
    }

}
