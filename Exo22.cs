using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo22
    {
        public void Execute()
        {
            float value1 = CheckInput();
            float value2 = CheckInput();
            float value3 = CheckInput();
            List<float> list = new List<float>() { value1, value2, value3};
            list.Sort();
            foreach (float f in list)
            {
                Console.WriteLine(f);
            }
        }

        private float CheckInput()
        {
            Console.WriteLine("Tapez un nombre à virgule :");
            bool correctInput = false;
            float result = 0;
            while (!correctInput) 
            {
                string input = Console.ReadLine();
                input = input.Replace(',','.');
                try
                {
                    result = float.Parse(input, CultureInfo.InvariantCulture);
                    correctInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ne tapez que des nombres a virgule SVP !");
                }
            }

            return result;
        }
    }
}
