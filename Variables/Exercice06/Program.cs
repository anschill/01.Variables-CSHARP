using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice06
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, firstname;
            int year = 0;
            int birth;

            Console.WriteLine("Entrez le nom :");
            name = Console.ReadLine();
            Console.WriteLine("Entrez le prénom : ");
            firstname = Console.ReadLine();
            Console.WriteLine("Entrez l'année de naissance : ");
            int.TryParse(Console.ReadLine(), out year);

            birth = (DateTime.Now.Year - year);
            Console.WriteLine("Nom : " + name + "\n" + "Prénom : " + firstname + "\n" + "Âge : " + birth + " \n");
        }
    }
}
