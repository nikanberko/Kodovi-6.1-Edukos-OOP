using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class DeliveryDrone
    {
        protected double range;
        protected double maxWeight;

        public DeliveryDrone(double range, double maxWeight)
        {
            this.range = range;
            this.maxWeight = maxWeight;
        }

        public static bool operator== (DeliveryDrone lhs, DeliveryDrone rhs)
        {
            return lhs.range == rhs.range && lhs.maxWeight == rhs.maxWeight;
        }

        public static bool operator!= (DeliveryDrone lhs, DeliveryDrone rhs)
        {
            return !(lhs == rhs);
        }

        public virtual bool CheckDeliverability(double packageWeight, double distance )
        {
            if (distance <= range && packageWeight <= maxWeight) return true;
            return false;

        } 
    }
}
