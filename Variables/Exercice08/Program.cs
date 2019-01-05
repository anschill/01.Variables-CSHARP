using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice08
{
    class Program
    {
        static void Main(string[] args)
        {
            double rayon = 0;
           
          
            Console.WriteLine("Donnez une valeur au rayon du cercle : ");
            double.TryParse(Console.ReadLine(), out rayon);

            Console.WriteLine("Le rayon du cercle de " + rayon + " a un perimetre de " + ( 2 * Math.PI * rayon ));
            Console.WriteLine("Le rayon du cercle de " + rayon + " a une surface de " + (Math.PI * (Math.Pow(rayon, 2))));
        }
    }
}
