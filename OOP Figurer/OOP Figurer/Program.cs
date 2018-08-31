using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Figurer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opretter en liste til og sætte figurer ind
            List<Figur> Figurliste = new List<Figur>();
            Figurliste.Add(new Kvadrat(2));
            Figurliste.Add(new Cirkel(8));

            //For hver linjie i listen udskriver den hvad der står på linjien
            foreach (var f in Figurliste)
            {
                Console.WriteLine(f.UdskrivFigur());
            }

            //Slut
            Console.ReadKey();
        }
    }
}
