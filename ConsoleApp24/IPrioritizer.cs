using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    interface IPrioritizer
    {
        public List<Package> GetModifiedPackages(List<Package> packages);

        public List<string> GetCities(List<Package> packages);

    }
}
