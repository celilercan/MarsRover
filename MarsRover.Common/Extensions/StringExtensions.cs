using MarsRover.Common.Enums;

namespace MarsRover.Common.Extensions
{
    public static class StringExtensions
    {
        public static int ToIntOrDefault(this string str)
        {
            int.TryParse(str, out int val);

            return val;
        }

        public static Direction GetDirection(this string shortCode)
        {
            switch (shortCode)
            {
                case "N":
                    return Direction.North;
                case "S":
                    return Direction.South;
                case "E":
                    return Direction.East;
                case "W":
                    return Direction.West;
                default:
                    return Direction.North;
            }
        }
    }
}
