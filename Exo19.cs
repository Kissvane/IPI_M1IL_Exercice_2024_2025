using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo19
    {
        public void Execute()
        {
            Console.WriteLine("Tapez un mot:");
            string input = Console.ReadLine();
            char[] inputInChar = new char[input.Length];
            string result1 = "";
            for (int i = 0; i < input.Length; i++)
            {
                inputInChar[i] = input[i];
                result1 += $"{inputInChar[i]}.";
            }
            result1 = result1.Remove(result1.Length-1);
            Console.WriteLine(result1);

            inputInChar = inputInChar.Reverse().ToArray();

            string result2 = "";
            foreach (char c in inputInChar)
            {
                result2 += c;
            }
            Console.WriteLine(result2);
        }
    }
}
