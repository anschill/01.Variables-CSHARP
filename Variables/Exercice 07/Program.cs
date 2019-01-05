using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double BC = 0;
            double CA = 0;
            double AB = 0;



            Console.WriteLine("Donnez une valeur à BC : ");
            double.TryParse(Console.ReadLine(), out BC);
            Console.WriteLine("Donnez une valeur à CA :");
            double.TryParse(Console.ReadLine(), out CA);

            AB = (Math.Pow(BC, 2) + Math.Pow(CA, 2));
            AB = Math.Sqrt(AB);

            Console.WriteLine("Si le triangle ABC est rectangle en C, et que BC = " + BC + " , que CA = " + CA + " , alors AB = " + AB);
        }
    }
}
