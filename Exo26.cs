﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPI_C_sharp_2024_2025_M1IL
{
    public class Exo26
    {
        public void Execute()
        {
            HashSet<int> hashset = new HashSet<int>();
            for(int i = 0; i <= 100; i++)
            {
                hashset.Add(i);
            }

            hashset.Add(0);

            for (int i = 40; i <= 50; i++)
            {
                hashset.Remove(i);
            }

            StringBuilder builder = new StringBuilder();
            foreach (int i in hashset)
            {
                builder.Append($"{i}-");
            }
            builder.Remove(builder.Length-1,1);
            Console.WriteLine(builder.ToString());
        }
    }
}
