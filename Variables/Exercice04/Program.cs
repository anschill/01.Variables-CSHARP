using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice04
{
    class Program
    {
        static void Main(string[] args)
        {
            string civilite;
            string prenom;
            int fois;

            civilite = "Monsieur";
            prenom = "Vincent";
            fois = 1;

            Console.WriteLine("Bonjour " + civilite + " " + prenom + ", vous êtes venu nous rendre visite " + fois + " fois");
        }
    }
}
