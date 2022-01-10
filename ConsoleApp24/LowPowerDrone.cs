using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class LowPowerDrone:DeliveryDrone
    {
        bool lowPowerSwitch;

        public LowPowerDrone(bool lowPowerSwitch, double range, double maxWeight):base(range, maxWeight)
        {
            this.lowPowerSwitch = lowPowerSwitch;

        }

        public void switchPowerMode()
        {
            lowPowerSwitch = !lowPowerSwitch;
        }

        public override bool CheckDeliverability(double packageWeight, double distance)
        {
            if (lowPowerSwitch == true && distance<= range*1.2 && packageWeight <= maxWeight)
            {
                return true;
                
            }
            

            return false;
        }
    }
}
