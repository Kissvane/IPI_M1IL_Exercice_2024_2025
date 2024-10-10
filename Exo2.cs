using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_202
{
    public class Exo2
    {
        public void Execute()
        {
            Console.WriteLine("Tapez votre année de naissance:");
            string birthYear = Console.ReadLine();
            int birthYearInt = int.Parse(birthYear);
            int age = DateTime.Now.Year - birthYearInt;
            Console.WriteLine($"Vous avez {age} ans.");
        }

        public void Execute2()
        {
            Console.WriteLine("Tapez votre année de naissance:");
            int birthYear = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez votre mois de naissance:");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez votre jour de naissance:");
            int birthDay = int.Parse(Console.ReadLine());
            int age = DateTime.Now.Year - birthYear;

            if (DateTime.Now.Month < birthMonth || //si le mois de mon anniversaire n'est pas encore passé
                (DateTime.Now.Month == birthMonth && DateTime.Now.Day < birthDay)) // si nous sommes dans le mois de mon anniversaire mais que le jour n'est pas passé
            {
                age--;
            }

            Console.WriteLine($"Vous avez {age} ans.");
        }
    }
}
