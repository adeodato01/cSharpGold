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

        private static List<Location> locations = new List<Location>();

        private static int goldTotal = 0;

        /// <summary>
        /// Method that creates locations
        /// </summary>
        /// <param name="locationName">Location name</param>
        /// <returns></returns>
        public static Location CreateLocation(LocationType locationName)
        {
            var location = new Location
            {
                LocationName = locationName
                //LowAmount = lowestGold,
                //HighAmount = highestGold
                
                //Gold = location.GoldAmount();
            };
            location.HighLow(locationName);
            goldTotal = location.GoldAmount();
            //Console.WriteLine($"the LOW amount is now {location.LowAmount}");
            //Console.WriteLine($"the HIGH amount is now {location.HighAmount}");

            locations.Add(location);

            return location;
        }

        public static IEnumerable<Location> GetAllLocationsForUser()
        {
            return locations;
        }

        public static User CreateUser()
        {
            var user = new User { };
            return user;
        }
    }
}
