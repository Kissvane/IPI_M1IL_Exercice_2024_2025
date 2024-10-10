using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_202
{
    public class Exo5
    {
        private void Addition(int value1, int value2)
        {
            Console.WriteLine($"{value1}+{value2}={value1 + value2}");
        }

        private void Division(int value1, int value2)
        {
            Console.WriteLine($"{value1}/{value2}={value1 / value2} reste {value1 % value2}");
        }

        public void Execute()
        {
            Console.WriteLine("Tapez un nombre:");
            string v1 = Console.ReadLine();
            int value1;
            if (!int.TryParse(v1, out value1))
            {
                Console.WriteLine("Ne tapez que des chiffres SVP !");
                Execute();
                return;
            }

            Console.WriteLine("Tapez un nombre:");
            string v2 = Console.ReadLine();
            int value2;
            if (!int.TryParse(v2, out value2))
            {
                Console.WriteLine("Ne tapez que des chiffres SVP !");
                Execute();
                return;
            }

            Addition(value1, value2);
            if (value2 != 0)
            {
                Division(value1, value2);
            }
            else
            {
                Console.WriteLine("Impossible de diviser par 0");
            }
        }
    }
}
