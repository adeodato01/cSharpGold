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
        public decimal Gold { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Calculations for the amount of Gold to be given / taken away
        /// </summary>
        public void GoldAmount()
        {
            /// calculations to determine how much gold given / taken away
        }
        
        #endregion
    }
}
