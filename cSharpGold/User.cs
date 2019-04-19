using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpGold
{
    /// <summary>
    /// User class stores a High Score
    /// </summary>
    class User
    {
        #region Statics
        private static int lastUserNumber = 0;
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor sets the first user to 1
        /// </summary>
        public User()
        {
            
            UserNumber = ++lastUserNumber; 
            CreatedDate = DateTime.Now;
        }
        #endregion

        #region Properties
        /// <summary>
        /// User's high score
        /// </summary>
        public int HighScore { get; private set; }
        /// <summary>
        /// User number, private to the game
        /// </summary>
        public int UserNumber { get; private set; }
        /// <summary>
        /// User name set by user after exiting the game if score is among the 5 highest
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// User Created Date
        /// </summary>
        public DateTime CreatedDate { get; private set; }
        #endregion
    }
}
