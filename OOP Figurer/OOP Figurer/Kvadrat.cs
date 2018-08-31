using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Figurer
{
    class Kvadrat : Figur
    {
        //Metode til og skaffe Areal //Der overskrives den tomme skabelon fra "Figur Klassen"
        override public double GetAreal()
        {
            return Size * Size;
        }

        //Metode til og udskrive figur //Der overskrives den tomme skabelon fra "Figur Klassen"
        public override double UdskrivFigur()
        {
            return GetAreal();
        }

        //Custom constructor "Kvadrat"
        public Kvadrat(double s)
        {
            Size = s;
        }
    }
}

