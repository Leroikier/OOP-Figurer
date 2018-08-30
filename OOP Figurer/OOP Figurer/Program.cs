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
            Kvadrat k1 = new Kvadrat { Size = 40 };
            Cirkel c1 = new Cirkel { Size = 20 };

            k1.GetAreal();

            Console.ReadKey();
        }
    }
}
