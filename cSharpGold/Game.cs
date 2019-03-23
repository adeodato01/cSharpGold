using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpGold
{
    /// <summary>
    /// Game is static because it's the factory that creates Locations in the game
    /// </summary>
    static class Game
    {
        /// <summary>
        /// Method that creates locations
        /// </summary>
        /// <param name="locationName">Location name</param>
        /// <param name="lowestGold">Smallest amount of gold given</param>
        /// <param name="highestGold">Highest amount of gold given</param>
        /// <returns></returns>
        public static Location CreateLocation(string locationName, int lowestGold, int highestGold)
    {
            var location = new Location
            {
                LocationName = locationName,
                LowAmount = lowestGold,
                HighAmount = highestGold
                
                //Gold = location.GoldAmount();
            };
            location.GoldAmount();
            Console.WriteLine($"the LOW amount is now {location.LowAmount}");
            Console.WriteLine($"the HIGH amount is now {location.HighAmount}");
            return location;
        }
    }
}
