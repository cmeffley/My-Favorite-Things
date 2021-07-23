using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Favorite_Things.Interests
{
    class Soccer
    {
        public string Forward { get; set; }
        public string ShotPosition { get; set; }
        public string Goalie { get; set; }
        public int Score { get; private set; }


        bool _isGoal;


        public void Goal()
        {
            if (ShotPosition == "corner")
            {
                Console.WriteLine($"{Forward} scores!");
                _isGoal = true;
                Score++;
                Console.WriteLine($"The Score is now {Score} to 0");

            } 
            else if (ShotPosition == "middle")
            {
                Console.WriteLine($"{Goalie} saves!");
                _isGoal = false;
                Console.WriteLine($"The Score is still {Score} to 0");
            }
        }

        public void Victory()
        {
            if (Score >= 1)
            {
                Console.WriteLine($"{Forward} wins! {Goalie} loses");
            }
            else if (Score == 0)
            {
                Console.WriteLine($"{Goalie} wins! {Forward} loses!");
            }
        }
    }
}
