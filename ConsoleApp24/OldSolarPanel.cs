using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class OldSolarPanel:SolarPanel
    {
        int age;
       
        double agingFactor;

        public OldSolarPanel(int age, double agingFactor, double width, double height, double efficiency):base(width, height, efficiency)
        {
            this.age = age;
            this.agingFactor = agingFactor;

        }
        public OldSolarPanel()
        {
            age = 5;
            agingFactor = 0.1;
        }
        

        public void IncrementAge()
        {
            age++;
        }
        
    }
}
