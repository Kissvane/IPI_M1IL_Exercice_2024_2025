using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo18
    {
        public void Execute(int[] array1, int[] array2, int index)
        {
            int[] result = new int[array1.Length + array2.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                if (i < index) 
                {
                    result[i] = array1[i];
                }
                else if (i == index)
                {
                    for (int j = 0; j < array2.Length; j++)
                    {
                        result[i+j] = array2[j];
                    }
                    result[i + array2.Length] = array1[i];
                }
                else
                {
                    result[i + array2.Length] = array1[i];
                }
            }

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
    }
}
