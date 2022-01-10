using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class EfficiencyException:Exception
    {   
        public double BadEfficiency { get; set; }

        public EfficiencyException():base()
        {

        }

        public EfficiencyException(string message):base(message)
        {

        }
        public EfficiencyException(string message, double badEfficiency) : base(message)
        {
            BadEfficiency = badEfficiency;
        }




    }
}
