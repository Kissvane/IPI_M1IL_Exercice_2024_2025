using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo24
    {
        public void Execute()
        {
            List<string> names = new List<string>();
            bool hasEnteredANumber = false;
            while (names.Count < 6 || !hasEnteredANumber)
            {
                if (names.Count < 6) 
                {
                    names.Add(EnterAName());
                }
                else
                {
                    if (EnterANameOrANumber(names))
                    {
                       hasEnteredANumber = true;
                    }
                }
            }

            names.RemoveAt(4);
            names.RemoveAt(1);
            names.Insert(2,"toto");

            names.Reverse();
            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
        }

        private bool EnterANameOrANumber(List<string> names)
        {
            Console.WriteLine("Entrez un nom ou un nombre");
            while (true)
            {
                string input = Console.ReadLine();
                if (IsName(input))
                {
                    names.Add(input);
                    return false;
                }
                else if(IsNumber(input))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Entrez un nom ou un nombre. Rien d'autre svp.");
                }
            }
        }

        private string EnterAName()
        {
            Console.WriteLine("Entrez un nom");
            while (true)
            {
                string input = Console.ReadLine();
                if (IsName(input))
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Pas assez de noms pour le moment");
                }
            }
        }

        private bool IsName(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsNumber(string value)
        {
            foreach (char c in value)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
