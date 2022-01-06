using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
//Iz klase FoodTracker izvedite klasu NutritionalTracker s atributima koji predstavljaju pragove 
//kaloricne vrijednosti i tezine porcije.Definirajte parametarski konstruktor.
//Prepisite metodu za izracun ukupne
////zarade tako na ukupnu zaradu za svaku porciju koja je tezinom ispod, a kaloricnom vrijednoscu
//iznad odgovarajuceg praga pridoda jos donaciju drzave u iznosu od deset posto vrijednosti porcije. 
    class NutritionalTracker:FoodTracker
    {
        public double KcalThreshold { get; set; }
        public double WeightThreshold { get; set; }

        public NutritionalTracker(double kcalThreshold, double weightThreshold):base()
        {
            KcalThreshold = kcalThreshold;
            WeightThreshold = weightThreshold;
        }
        public override decimal CalculateProfit()
        {
            decimal totalProfit = 0;

            foreach (Portion portion in Portions)
            {
                if(portion.Weight<WeightThreshold && portion.Kcal > KcalThreshold)
                {
                    totalProfit += portion.Price + portion.Price * (decimal)0.1;
                }
                else
                {
                    totalProfit += portion.Price;
                }
            

            }
            return totalProfit;
        }

    }
}
