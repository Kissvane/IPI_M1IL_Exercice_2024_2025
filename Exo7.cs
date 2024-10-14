using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo7
    {
        public void Execute()
        {
            Console.WriteLine("Tapez une température:");
            int temperature = int.Parse(Console.ReadLine());
            if (temperature <= 0)
            {
                Console.WriteLine("ETAT SOLIDE");
            }
            else if (temperature < 100)
            {
                Console.WriteLine("ETAT LIQUIDE");
            }
            else
            {
                Console.WriteLine("ETAT GAZEUX");
            }
        }
    }
}
