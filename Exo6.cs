using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_202
{
    internal class Exo6
    {
        public enum TrafficColor { Green, Orange, Red}

        public void Execute()
        {
            Console.WriteLine("Tapez une couleur de feu:");
            string input = Console.ReadLine();
            TrafficColor color = 
                (TrafficColor) Enum.Parse(typeof(TrafficColor), input);
            TrafficColor nextColor = (TrafficColor)(((int)color + 1) % Enum.GetNames(typeof(TrafficColor)).Length);
            Console.WriteLine($"Prochain état {nextColor.ToString()}");
        }

        public void Execute2()
        {
            Console.WriteLine("Tapez une couleur de feu:");
            string input = Console.ReadLine();
            TrafficColor color = TrafficColor.Green;
            switch (input.ToLower())
            {
                case "green":
                    color = TrafficColor.Green;
                    break;
                case "orange":
                    color = TrafficColor.Orange;
                    break;
                case "red":
                    color = TrafficColor.Red;
                    break;
            }

            TrafficColor nextColor = (TrafficColor)(((int)color + 1) % Enum.GetNames(typeof(TrafficColor)).Length);
            Console.WriteLine($"Prochain état {nextColor.ToString()}");
        }
    }
}
