using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Figurer
{
    abstract class Figur
    {
        public double Size;

        public double GetAreal(double Size)
        {
            double areal = Size * Size;
            return areal;
        }
    }
}
