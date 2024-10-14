using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    internal class Exo16
    {
        public void Execute()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] result = new int[array.Length];
            string arrayString = "";
            string resultString = "";
            for (int i = 0; i < array.Length; i++)
            {
                arrayString += $"{array[i]}-";
                if(array[i] % 2 == 0)
                {
                    result[i] = i;
                }
                else
                {
                    result[i] = array[i];
                }
                resultString += $"{result[i]}-";
            }

            arrayString = arrayString.Remove(arrayString.Length-1);
            resultString = resultString.Remove(resultString.Length-1);

            Console.WriteLine(arrayString);
            Console.WriteLine(resultString);
        }
    }
}
