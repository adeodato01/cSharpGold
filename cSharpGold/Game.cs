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
        private static GameContext db = new GameContext();

        private static int goldTotal = 0;

        /// <summary>
        /// Method that creates locations
        /// </summary>
        /// <param name="locationName">Location name</param>
        /// <returns>Returns an individual location with Random Gold amount</returns>
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

            db.Locations.Add(location);
            db.SaveChanges();

            return location;
        }

        /// <summary>
        /// A method that interates through a list of Locations
        /// </summary>
        /// <returns>a list of Locations that can be iterated through</returns>
        public static IEnumerable<Location> GetAllLocationsForUser()
        {
            return db.Locations;
        }

        public static User CreateUser()
        {
            var user = new User { };
            return user;
        }
    }
}
