using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo9
    {
        public void Execute()
        {
            for (int i = 0; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Execute2()
        {
            for (int i = 0; i <= 20; i = i+2)
            {
                Console.WriteLine(i);
            }
        }

        public void Execute3()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i*2);
            }
        }
    }
}
