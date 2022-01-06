using System;
using System.Collections.Generic;

namespace ConsoleApp24
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGenerator = new Random();
            
            int n;
            n= int.Parse(Console.ReadLine());

            List<SolarPanel> panels = new List<SolarPanel>();

            for(int i=0; i<n; i++)
            {
                panels.Add(new SolarPanel(randomGenerator.NextDouble()*9, randomGenerator.NextDouble() * 9, randomGenerator.NextDouble()));
            }

            for (int i = n/2; i < n; i++)
            {
                panels.Add(new OldSolarPanel(randomGenerator.Next(0, 100), randomGenerator.NextDouble()*0.1, randomGenerator.NextDouble() * 9, randomGenerator.NextDouble() * 9, randomGenerator.NextDouble()));
            }



        }
    }
}
