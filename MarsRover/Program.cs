using System;
using MarsRover.Common.Extensions;
using MarsRover.Common.Helpers;
using MarsRover.Common.Models;
namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var combinedCoordinates = GetEnteredCoordinates();
                var plato = new Plato();
                var rover = new Rover(combinedCoordinates, plato);
                var commands = GetEnteredCommands();
                rover.Run(commands);

                Console.WriteLine($"The rover's current coordinates: {rover.X} {rover.Y} {rover.Direction.GetShortCode()}");

                Console.WriteLine("Do you want to continue? (y/n)");
                var isContinue = Console.ReadLine();
                if (isContinue.ToLower() != "y")
                    break;

            } while (true);
        }

        private static string GetEnteredCoordinates()
        {
            do
            {
                Console.WriteLine("Enter coordinates...");
                var enteredCoordinates = Console.ReadLine();
                if (CommonHelper.ValidateCoordinates(enteredCoordinates))
                    return enteredCoordinates;

                Console.WriteLine("You entered invalid coordinate. Would you like to try again? (y/n)");
                var isContinue = Console.ReadLine();
                if (isContinue.ToLower() != "y")
                    break;

            } while (true);

            Environment.Exit(0);
            return string.Empty;
        }

        private static string GetEnteredCommands()
        {
            do
            {
                Console.WriteLine("Enter commands...");
                var enteredCommands = Console.ReadLine();
                if (CommonHelper.ValidateCommands(enteredCommands))
                    return enteredCommands;
                
                Console.WriteLine("You entered invalid commands. Would you like to try again? (y/n)");
                var isContinue = Console.ReadLine();
                if (isContinue.ToLower() != "y")
                    break;

            } while (true);

            Environment.Exit(0);
            return string.Empty;
        }
    }
}
