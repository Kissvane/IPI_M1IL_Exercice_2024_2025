using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_202
{
    public class Exo4
    {
        private void Addition(int value1, int value2)
        {
            Console.WriteLine($"{value1}+{value2}={value1 + value2}");
        }

        private void Division(int value1, int value2)
        {
            Console.WriteLine($"{value1}/{value2}={value1/value2} reste {value1%value2}");
        }

        public void Execute()
        {
            Console.WriteLine("Tapez un nombre:");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Tapez un nombre:");
            int value2 = int.Parse(Console.ReadLine());
            Addition(value1, value2);
            Division(value1, value2);
        }
    }
}
