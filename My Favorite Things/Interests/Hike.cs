using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Favorite_Things.Interests
{
    class Hike
    {
        public string TrailName { get; set; }
        public int Length { get; set; }
        public string Weather { get; set; }

        string _strenuous = "Strenuous";
        string _easy = "Easy";
        public Hike(string name, int length)
        {
            TrailName = name;
            Length = length;
        }

        public void HowFar()
        {
            if (Length >= 10)
            {
                Console.WriteLine($"{TrailName} is a {_strenuous} hike");
            }
            else
            {
                Console.WriteLine($"{TrailName} is an {_easy} hike");
            }
        }

        public void Forcast()
        {
            Console.WriteLine($"The forcast is for {TrailName} trail is: {Weather}");
        }
    }
}
