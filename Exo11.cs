using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo11
    {
        public void Execute()
        {
            string result = null;
            for (int i = 30; i >= 0; i -= 3)
            {
                result += $"{i}-";
            }
            result = result.Remove(result.Length-1);
            Console.WriteLine(result);
        }
    }
}
