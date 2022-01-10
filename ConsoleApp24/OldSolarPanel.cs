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
        public override double GetYearlyEnergy()
        {
            double oldPanelEfficiency= Efficiency - age * agingFactor;
            if (oldPanelEfficiency < 0.02) throw new EfficiencyException("Kod se raspo jer je efficiency manji od 0.02",oldPanelEfficiency );
            return Height * Width * oldPanelEfficiency * 1300;

        }

    }
}
