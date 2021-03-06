﻿using System;

namespace cSharpGold
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("********************");
            Console.WriteLine("Welcome to c# Gold!");
            Console.WriteLine("********************");

            while (true)
            {


                Console.WriteLine("0. Exit Program");
                Console.WriteLine("1. Play a New C# Gold Game");
                Console.Write("Select an option: ");
                var option = Console.ReadLine();
                switch (option)
                {
                    case "0":
                        Console.WriteLine("Thank you for playing C# Gold!");
                        return;
                    case "1":
                        while (true)
                        {
                            Console.WriteLine("0. Quit Game");
                            Console.WriteLine("1. Choose a Location");
                            Console.WriteLine("2. Display Total Gold");
                            Console.WriteLine("3. List Locations Visited");
                            Console.Write("Select and option: ");
                            var option1 = Console.ReadLine();
                            switch (option1)
                            {
                                case "0":
                                    Console.WriteLine("Thank you for playing C# Gold!");
                                    break;
                                case "1":
                                    try
                                    {

                                        var locationTypes = Enum.GetNames(typeof(LocationType));
                                        for (int i = 0; i < locationTypes.Length; i++)
                                        {
                                            Console.WriteLine($"{i + 1}. {locationTypes[i]}");
                                        }

                                        Console.Write("Choose a location: ");
                                        var locationType = Enum.Parse<LocationType>(Console.ReadLine());

                                        var l1 = Game.CreateLocation(locationType);

                                        Console.WriteLine($"Location Name: {l1.LocationName}, Gold Awarded: {l1.Gold}, Total Gold: l1.goldTotal"); //check out formatting like :C
                                    }
                                    catch (ArgumentException ax)
                                    {
                                        Console.WriteLine($"Location Type Error - {ax.Message} - Please try again!");
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine($"Sorry something went wrong - {ex.Message} - Please try again");
                                    }
                                    continue;

                                case "2":
                                    break;

                                case "3":

                                    var locations = Game.GetAllLocationsForUser();
                                    foreach (var place in locations)
                                    {
                                        Console.WriteLine($"Place: {place.LocationName}, Gold: {place.Gold}");
                                    }
                                    break;
                                default:
                                    break;
                            }
                            break;
                        }
                        break;
                        
                    default:
                        break;
                }
            }
        }
    }
}
