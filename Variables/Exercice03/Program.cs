using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;

            Console.WriteLine("Donnez une valeur :");
            int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Donnez une seconde valeur :");
            int.TryParse(Console.ReadLine(), out b);

            a = (a + 33);
            b++;

            Console.WriteLine("Le resultat de " + a + " / " + b + " = " + (a/b));
            Console.ReadKey();
      
            
        }
    }
}
