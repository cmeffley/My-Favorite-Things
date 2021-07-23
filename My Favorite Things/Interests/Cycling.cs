using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Favorite_Things.Interests
{
    class Cycling
    {
        public string Type { get; set; }
        public int RideDistance { get; set; }
        


        public void Ride()
        {
            Console.WriteLine($"I rode {RideDistance} today.");
        }

        public void Bike(string Rider)
        {
            if (Type == "road")
            {
                Console.WriteLine($"{Rider}, which way are you going?");
            }
            else if (Type == "mountain")
            {
                Console.WriteLine($"{Rider}, are you doing XC or downhill?");
            }
        }   



    }
}
