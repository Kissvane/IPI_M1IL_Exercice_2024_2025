using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo13
    {
        public void Execute()
        {
            int result = 0;
            while (true)
            {
                Console.WriteLine("Tapez un nombre");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    result += value;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(result);
        }

        public void Execute2()
        {
            int result = 0;
            bool userEnteredANumber = true;
            while (userEnteredANumber)
            {
                Console.WriteLine("Tapez un nombre");
                string input = Console.ReadLine();

                userEnteredANumber = int.TryParse(input, out int value);
                if (userEnteredANumber)
                {
                    result += value;
                } 
            }

            Console.WriteLine(result);
        }
    }
}
