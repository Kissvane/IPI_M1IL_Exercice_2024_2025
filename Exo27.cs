using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo27
    {
        public void Execute()
        {
            Dictionary<string, int> scores = new Dictionary<string, int>();
            scores.Add("Paris", 8000);
            scores.Add("Toulouse", 2000);
            scores.Add("Montpellier", 4000);
            scores.Add("Nice", 5000);
            scores.Add("St Roustan", 3);

            Stopwatch stopwatch = Stopwatch.StartNew();
            scores.ContainsKey("St Roustan");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);

            Random rand = new Random();

            for (int i = 0; i < 10000; i++)
            {
                scores.Add(i.ToString(), rand.Next(10000));
            }

            stopwatch.Restart();
            scores.ContainsKey("St Roustan");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);

            List<string> keys = scores.Keys.ToList();
            List<int> indexes = new List<int>();
            for (int i = 0; i < keys.Count; i++)
            {
                indexes.Add(i);
            }
            for (int i = 0; i < 5; i++)
            {
                int index = rand.Next(indexes.Count);
                indexes.Remove(index);
                Console.WriteLine($"{keys[index]}:{scores[keys[index]]}");
            }
        }
    }
}
