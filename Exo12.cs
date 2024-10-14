using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo12
    {
        public void Execute()
        {
            int start = 2;
            while (start <= 21)
            {
                Console.WriteLine(start);
                start += 3;
            }
            Console.WriteLine(start);
        }
    }
}
