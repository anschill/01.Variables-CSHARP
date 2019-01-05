using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            string prenom;

            Console.WriteLine("Quel est votre prénom ?");
            prenom = Console.ReadLine();
            Console.WriteLine("Quel est votre nom ? ");
            nom = Console.ReadLine();

            Console.WriteLine("Bonjour " + prenom + " " + nom + ", nous sommes le " + DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + " comment allez-vous ?");
            Console.ReadKey();
        }
    }
}
