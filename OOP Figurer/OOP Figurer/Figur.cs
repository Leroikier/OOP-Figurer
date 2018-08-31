using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Figurer
{
    abstract class Figur
    {
        //Variabel
        public double Size;

        //Abstract Getareal
        abstract public double GetAreal();

        //Abstract Udskrivfigur
        abstract public double UdskrivFigur();
    }
}
