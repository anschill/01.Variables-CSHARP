using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int z;
            int somme;
            int result;

            x = 1;
            y = 2;
            z = 8;

            Console.WriteLine("x = " + x + ", y = " + y + ", z = " + z);

            somme = (x + y);
            result = (somme * z);
            Console.WriteLine("Le résultat de ( " + x + " + " + y + " ) x " + z + " = "  + result);
          }
    }
}
