using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo23
    {
        public void Execute()
        {
            int value1 = CheckInput();
            int value2 = CheckInput();
            int value3 = CheckInput();
            int value4 = GetRandomValueBetween1And100();
            int value5 = GetRandomValueBetween1And100();
            int value6 = GetRandomValueBetween1And100();
            List<int> list = new List<int>() { value1, value2, value3, value4, value5, value6 };
            list = list.OrderDescending().ToList();
            Console.WriteLine("----------------------");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }

        private int GetRandomValueBetween1And100()
        {
            Random random = new Random();
            return random.Next(100) + 1;
        }

        private int CheckInput()
        {
            Console.WriteLine("Tapez un nombre :");
            bool correctInput = false;
            int result = 0;
            while (!correctInput)
            {
                string input = Console.ReadLine();
                input = input.Replace(',', '.');
                try
                {
                    result = int.Parse(input, CultureInfo.InvariantCulture);
                    correctInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ne tapez que des nombres !");
                }
            }

            return result;
        }
    }
}
