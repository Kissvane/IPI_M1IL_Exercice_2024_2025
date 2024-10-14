using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo3
    {
        public int Toto { get;private set; }

        public void CalculateTVA()
        {
            Console.WriteLine("Tapez le prix hors-taxe:");
            int htPrice = int.Parse(Console.ReadLine());
            int tva = htPrice * 20 / 100;
            int ttcPrice = htPrice + tva;
            Console.WriteLine($"Le prix TTC est de {ttcPrice}");
        }

        public void CalculateTvaFloat() 
        {
            Console.WriteLine("Tapez le prix hors-taxe:");
            float htPrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Tapez le taux de TVA:");
            float tvaRate = float.Parse(Console.ReadLine());
            float tva = htPrice * tvaRate / 100.0f;
            float ttcPrice = htPrice + tva;
            Console.WriteLine($"Le prix TTC est de {ttcPrice}");
        }
    }
}
