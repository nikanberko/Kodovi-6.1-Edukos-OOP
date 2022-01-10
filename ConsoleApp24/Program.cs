using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp24
{
    class Program
    {

       


        public static int GetNumOfPackages(DeliveryDrone drone, double[] weights , double distance )
        {
            int packageCounter = 0;
            
            for (int i = 0; i < weights.Length; i++)
                {

                    if (drone.CheckDeliverability(weights[i], distance))
                    {
                        packageCounter++;
                    }

                }
            if (packageCounter < (weights.Length / 2))
                throw new DeliveryException((double)packageCounter/weights.Length*100, "Less than half of the packages deliverable");

            return packageCounter;
        }


        static void Main(string[] args)
        {
            LowPowerDrone lpd = new LowPowerDrone(true, 1200, 50);

            double[] weights = new double[4];


            weights[0] = 50;
            weights[1] = 100;
            weights[2] = 300;
            weights[3] = 400;

            int n;
            try
            {

               n =GetNumOfPackages(lpd, weights, 1337);

            }
            catch (DeliveryException e)
            {
                Console.WriteLine(e.Message + " " + e.DeliveryPercentage); 

            }
        }
    }
}
