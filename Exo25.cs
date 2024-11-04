using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo25
    {
        public void Execute()
        {
            Stopwatch sw = Stopwatch.StartNew();
            HashSet<int> hashset = new HashSet<int>();
            for (int i = 0; i <= 1000000; i++)
            {
                hashset.Add(i);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            sw.Restart();
            List<int> list = new List<int>();
            for (int i = 0; i <= 1000000; i++)
            {
                list.Add(i);
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            sw.Restart();
            hashset.Contains(800000);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            sw.Restart();
            list.Contains(800000);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            sw.Restart();
            hashset.Remove(800000);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);

            sw.Restart();
            list.RemoveAt(800000);
            sw.Stop();
            Console.WriteLine(sw.ElapsedTicks);
        }
    }
}
