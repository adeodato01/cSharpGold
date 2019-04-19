using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpGold
{

    enum LocationType
    {
        Cave = 1,
        House,
        Farm,
        Casino
    }


    /// <summary>
    /// Place where various amounts of Gold are given / taken away
    /// </summary>
    class Location
    {
        #region Properties
        /// <summary>
        /// Name of the Location
        /// </summary>
        public LocationType LocationName { get; set; }
        /// <summary>
        /// Amount of Gold to be given / taken away
        /// </summary>
        public int Gold { get; private set; }

        public int LowAmount { get; private set; }

        public int HighAmount { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Randomly calculates for the amount of Gold to be given / taken away
        /// </summary>
        public int GoldAmount()
        {
            /// calculations to determine how much gold given / taken away
            //LowAmount = lowAmount;
            //HighAmount = highAmount;

            Random random = new Random();
            
            //Console.WriteLine($"The low is {LowAmount}");
            //Console.WriteLine($"The high is {HighAmount}");

            Gold = random.Next(LowAmount, HighAmount++);

            //Console.WriteLine($"The amount of gold SHOULD be {Gold}");
            //return goldAmount;

            return Gold;
        }

        /// <summary>
        /// Method to assign High and Low amounts for each specific Location
        /// </summary>
        /// <param name="locationName">Takes in a Location from the Enum</param>
        public void HighLow(LocationType locationName)
        {
            if (locationName == LocationType.Cave)
            {
                LowAmount = 0;
                HighAmount = 15;
            }
            if (locationName == LocationType.House)
            {
                LowAmount = 2;
                HighAmount = 5;
            }
            if (locationName == LocationType.Farm)
            {
                LowAmount = 3;
                HighAmount = 10;
            }
            if (locationName == LocationType.Casino)
            {
                LowAmount = -500;
                HighAmount = 200;
            }
        }
        #endregion

        #region Constructor
        public Location()
        {
            //GoldAmount();
        }
        #endregion
    }
}
