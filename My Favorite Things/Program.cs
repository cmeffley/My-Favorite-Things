using My_Favorite_Things.Interests;
using System;

namespace My_Favorite_Things
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cycling class
            var rider = new Cycling
            {
                Type = "road",
                RideDistance = 150
            };

            rider.Ride();
            rider.Bike("Chris");

            var otherRider = new Cycling
            {
                Type = "mountain",
                RideDistance = 75
            };

            otherRider.Ride();
            otherRider.Bike("Doug");

            //Soccer class
            var messi = new Soccer
            {
                Forward = "Messi",
                Goalie = "Czech",
                ShotPosition = "corner"
            };

            messi.Goal();
            messi.Victory();

            var donovan = new Soccer
            {
                Forward = "Donovan",
                Goalie = "Howard",
                ShotPosition = "middle"
            };

            donovan.Goal();
            donovan.Victory();

            //Cars class
            var classic = new Cars("Ford", "Mustang", 1967);
            classic.TradeIn("Chris");
            classic.Buy();

            var modern = new Cars("Aston Martin", "Valkyrie", 2020);
            modern.Buy();
            modern.TradeIn("Jeremy");

            // Hike class
            var waterfall = new Hike("Burgess Falls", 5);
            waterfall.Weather = "clear";

            waterfall.HowFar();
            waterfall.Forcast();

            var mountain = new Hike("Mt. Elba", 15);
            mountain.Weather = "cloudy";

            mountain.HowFar();
            mountain.Forcast();

        }


    }
}
