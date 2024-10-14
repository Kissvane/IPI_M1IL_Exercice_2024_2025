using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo8
    {
        private void Addition(int value1, int value2)
        {
            Console.WriteLine($"{value1}+{value2}={value1 + value2}");
        }

        private void Division(int value1, int value2)
        {
            try
            {
                Console.WriteLine($"{value1}/{value2}={value1 / value2} reste {value1 % value2}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division par zéro impossible");
            }
        }

        public void Execute()
        {
            int value1 = GetValidInput();
            int value2 = GetValidInput();
            Addition(value1, value2);
            Division(value1, value2);
        }

        private int GetValidInput()
        {
            bool validInput = false;
            int value = 0;
            while (!validInput)
            {
                Console.WriteLine("Tapez un nombre:");
                try
                {
                    value = int.Parse(Console.ReadLine());
                    validInput = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ne tapez que des nombres SVP !");
                }
            }
            return value;
        }
    }
}
