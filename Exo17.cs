using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    internal class Exo17
    {
        public void Execute()
        {
            int[] array1 = new int[] { 0, 2, 4, 6, 8, 10, 12, 14, 16};
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };
            int[] array3 = new int[array1.Length+array2.Length];
            int currentIndexInArray3 = 0;
            string result = "";
            for (int i = 0; i < Math.Max(array1.Length, array2.Length); i++)
            {
                if (array1.Length > i)
                {
                    array3[currentIndexInArray3] = array1[i];
                    result += $"{array3[currentIndexInArray3]}-";
                    currentIndexInArray3++;
                }
                if (array2.Length > i) 
                {
                    array3[currentIndexInArray3] = array2[i];
                    result += $"{array3[currentIndexInArray3]}-";
                    currentIndexInArray3++;
                }
            }
            result = result.Remove(result.Length-1);
            Console.WriteLine(result);
        }
    }
}
