using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class CityPrioritizer: IPrioritizer
    {
        List<string> cities = new List<string>();
        public void AddCity(string city) => cities.Add(city);


        public List<Package> GetModifiedPackages(List<Package> packages)
        {
            List<Package> prioritizedPackages = new List<Package>();
            
            double totalWeight=0;
            
            foreach(Package package in packages)
            {
                totalWeight += package.Weight;
            }
            double avgWeight =totalWeight / packages.Count;

            foreach(Package package in packages)
            {
                if(package.Weight>avgWeight && cities.Contains(package.City))
                {
                    prioritizedPackages.Add(package);
                }
            }
            return prioritizedPackages;
        }

        public List<string> GetCities(List<Package> packages)
        {
            int maxPriority = packages[0].Priority;

            List<string> prioritizedCities = new List<string>();

            foreach (Package package in packages)
            {
                if (package.Priority > maxPriority)
                {
                    maxPriority = package.Priority;
                }
            }

           


            foreach (Package package in packages)
            {
                if(package.Priority== maxPriority)
                {
                    prioritizedCities.Add(package.City);
                }

            }
            return prioritizedCities;

        }


    }
}
