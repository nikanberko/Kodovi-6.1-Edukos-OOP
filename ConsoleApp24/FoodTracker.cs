using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{

// Ako je dana klasa Portion prema izlistanju, definirajte vlastitu klasu FoodTracker
// koja omogucuje ´
//pohranu porcija u obliku liste.Za klasu FoodTracker definirajte metodu Track() koja omogucuje pohranu ´
//porcije te virtualnu metodu koja omogucuje izracun ukupne zarade.
    class FoodTracker
    {
        public List<Portion> Portions { get; private set; }

        public FoodTracker() {

            Portions = new List<Portion>();

        }
        
        public void Track(Portion portion)
        {
            Portions.Add(portion); 
        }

        public virtual decimal CalculateProfit()
        {
            decimal totalProfit = 0;
            foreach(Portion portion in Portions)
            {
                totalProfit += portion.Price;

            }
            return totalProfit;
        }  




    }
}
