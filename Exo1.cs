using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_202
{
    public class Exo1
    {
        public void Execute()
        {
            Console.WriteLine("Tapez votre prénom :");
            string firstName = Console.ReadLine();
            Console.WriteLine("Tapez votre nom :");
            string lastName = Console.ReadLine();
            Console.WriteLine($"Bonjour {firstName} {lastName}");
        }
    }
}
