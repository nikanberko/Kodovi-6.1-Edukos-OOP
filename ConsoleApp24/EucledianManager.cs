using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    //    ] Definirajte klasu EuclideanManager koja implementira sucelje iz zadatka 8 tako da se za provjeru ˇ
    //udaljenosti koristi Euklidska udaljenost odredena izrazom d =
    //p
    //(x2 − x1)
    //2 + (y2 − y1)
    //2

    class EucledianManager : ILocationManager
    {
        //Za predanu trenutnu lokaciju i listu susjednih lokacija pronalazak najblize lokacije medu susjednima.
        public Location GetNearestNeighbour(Location currentLocation, List<Location> neighbouringLocations)
        {
            Location nearestLoaction= neighbouringLocations[0];
            double nearestDistance = Math.Sqrt(Math.Pow(currentLocation.Latitude - neighbouringLocations[0].Latitude, 2) + Math.Pow(currentLocation.Longitude - neighbouringLocations[0].Longitude, 2));

            for (int i=0; i < neighbouringLocations.Count; i++)
            {

                double tempDistance = Math.Sqrt(Math.Pow(currentLocation.Latitude - neighbouringLocations[i].Latitude, 2) + Math.Pow(currentLocation.Longitude - neighbouringLocations[i].Longitude, 2));
               
                if (tempDistance < nearestDistance)
                {
                    nearestDistance = tempDistance;
                    nearestLoaction = neighbouringLocations[i];
                }

            }
            return nearestLoaction;
        }
        //• Za predanu lokaciju, listu susjednih lokacija i zeljenu udaljenost kreiranje nove liste koja sadrzi samo one ˇ
        //susjedne lokacije unutar zeljene udaljenosti.

        private double GetDistance(Location l1, Location l2)
        {
            return Math.Sqrt(Math.Pow(l1.Latitude - l2.Latitude, 2) + Math.Pow(l1.Longitude - l2.Longitude, 2));
        }

       

        public List<Location> GetLocationsWithinRange(Location location, List<Location> neighbouringLocations, double distance)
        {
            List<Location> locationsWithinRange= new List<Location>();
            
            

            for(int i=0;i<neighbouringLocations.Count; i++)
            {
                double tempDistance = GetDistance(location, neighbouringLocations[i]);
                
                if (tempDistance <= distance)
                {
                    locationsWithinRange.Add(neighbouringLocations[i]);
                }
            
            }

            return locationsWithinRange;


        }

     
    }
}
