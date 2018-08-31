using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Figurer
{
    class Cirkel : Figur
    {
        //Til og udregne radius af en cirkel //Der overskrives den tomme skabelon fra "Figur Klassen"
        public override double GetAreal()
        {
            return Math.PI * Math.Pow(Size, 2);
        }

        //Metode til og udskrive figur //Der overskrives den tomme skabelon fra "Figur Klassen"
        public override double UdskrivFigur()
        {
            return GetAreal();
        }

        //Custom constructor "Cirkel"
        public Cirkel(double s)
        {
            Size = s;
        }
    }
}
