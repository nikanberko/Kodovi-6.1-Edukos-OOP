using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class Utilities
    {

        public static bool AreUnique(SolarPanel[] solarPanels)
        {
            int counter = 0;

            for (int i=0;i< solarPanels.Length;i++)
            {
                for (int j=0; j<solarPanels.Length; j++)
                {
                    if(solarPanels[i]== solarPanels[j])
                    {
                        counter++;
                    }
                }
                if (counter > 1) return false;
                counter = 0;
            }
            return true;

        }
    }
}
