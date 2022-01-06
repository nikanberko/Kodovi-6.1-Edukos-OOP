using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
// definirajte sucelje ˇ ILocationManager koje ce za klase koje ga implementiraju omoguciti ´
//• Za predanu trenutnu lokaciju i listu susjednih lokacija pronalazak najblize lokacije medu susjednima.
//• Za predanu lokaciju, listu susjednih lokacija i zeljenu udaljenost kreiranje nove liste koja sadrzi samo one ˇ
//susjedne lokacije unutar zeljene udaljenosti.
    interface ILocationManager
    {
        public Location GetNearestNeighbour(Location currentLocation, List<Location> neighbouringLocations);

        public List<Location> GetLocationsWithinRange(Location location, List<Location> neighbouringLocations, double distance);

    }
}
