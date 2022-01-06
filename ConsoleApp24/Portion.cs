using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
     class Portion
 {
    public Portion(decimal price, double weight, double kcal)
    {
     Price = price; Weight = weight; Kcal = kcal;
    }

     public decimal Price { get; private set; }
     public double Weight { get; private set; }
     public double Kcal { get; private set; }
 }
}
