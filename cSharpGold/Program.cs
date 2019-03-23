using System;

namespace cSharpGold
{
    class Program
    {
        static void Main(string[] args)
        {

            var L1 = Game.CreateLocation("Cave", 3, 15);

            Console.WriteLine($"The location name is {L1.LocationName} " +
                $"and the amount of Gold you get is {L1.Gold} !!!!!!!!!");
        }
    }
}
