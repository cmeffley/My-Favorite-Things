using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Favorite_Things.Interests
{
    class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        bool _doesItRun;


        public Cars(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public void Buy()
        {
            if (Year >= 1985)
            {
                Console.WriteLine($"I am going to buy {Year} {Make} {Model}?");
                _doesItRun = true;
            }
            else
            {
                Console.WriteLine($"Do not buy this {Year} {Make} {Model}!");
                _doesItRun = false;
            }
        }

        public void TradeIn(string owner)
        {
            Console.WriteLine($"{owner}, do you want to upgrade and trade in your {Year} {Make} {Model}?");
        }
    }
}
