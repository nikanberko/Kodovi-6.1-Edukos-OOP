using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class DeliveryException: Exception
    {
        public double DeliveryPercentage { get; }

        public DeliveryException()
        {
            
        }

        public DeliveryException(double deliveryPercentage, string message) : base(message)
        {
            DeliveryPercentage = deliveryPercentage;
        }

    }
}
