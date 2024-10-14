using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo21
    {
        public void Execute()
        {
            Console.WriteLine("Ecrivez un mot:");
            string input = Console.ReadLine();
            bool result = true;
            for (int i = 0; i <= input.Length/2; i++)
            {
                if (input[i] != input[input.Length-1-i])
                {
                    result = false;
                    break;
                }
            }

            if (result)
            {
                Console.WriteLine($"{input} est un palindrome");
            }
            else
            {
                Console.WriteLine($"{input} n'est pas un palindrome");
            }
        }
    }
}
