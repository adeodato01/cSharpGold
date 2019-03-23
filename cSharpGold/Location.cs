using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpGold
{
    /// <summary>
    /// Place where various amounts of Gold are given / taken away
    /// </summary>
    class Location
    {
        #region Properties
        /// <summary>
        /// Name of the Location
        /// </summary>
        public string LocationName { get; set; }
        /// <summary>
        /// Amount of Gold to be given / taken away
        /// </summary>
        public int Gold { get; private set; }

        public int LowAmount { get; set; }

        public int HighAmount { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Calculations for the amount of Gold to be given / taken away
        /// </summary>
        public void GoldAmount()
        {
            /// calculations to determine how much gold given / taken away
            //LowAmount = lowAmount;
            //HighAmount = highAmount;

            Random random = new Random();
            
            Console.WriteLine($"The low is {LowAmount}");
            Console.WriteLine($"The high is {HighAmount}");

            Gold = random.Next(LowAmount, HighAmount++);

            Console.WriteLine($"The amount of gold SHOULD be {Gold}");
            //return goldAmount;
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
