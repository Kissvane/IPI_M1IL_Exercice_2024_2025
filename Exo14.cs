using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo14
    {
        public void Execute()
        {
            Console.WriteLine("Tapez un nombre :");
            int input = int.Parse(Console.ReadLine());
            int result = 0;
            while (input > 1)
            {
                input /= 2;
                result++;
            }
            Console.WriteLine(result);
        }
    }
}
