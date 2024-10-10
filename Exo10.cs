using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_202
{
    public class Exo10
    {
        public void Execute()
        {
            Console.WriteLine("Tapez un nombre");
            int value = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 0; i <= value; i++)
            {
                result += i;
            }

            Console.WriteLine(result);
        }
    }
}
