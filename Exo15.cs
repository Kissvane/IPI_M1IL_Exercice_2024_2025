using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo15
    {
        public void Execute()
        {
            int[] array = new int[9];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i + 5;
            }

            array[2] = 111;

            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}
