using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class SolarPanel
    {

        double width;
        double height;
        double efficiency;

        public SolarPanel(double width, double height, double efficiency)
        {
            this.width = width;
            this.height = height;
            this.efficiency = efficiency;
        }
        public SolarPanel()
        {
            width = 5;
            height = 5;
            efficiency = 0.2;
        }

        public virtual double GetYearlyEnergy()
        {
            return height * width * efficiency * 1300;
        }

      
        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }
        public double Efficiency { get => efficiency; set => efficiency = value; }

        
    }
}
