using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MarsRover.Common.Helpers
{
    public static class CommonHelper
    {
        public static bool ValidateCoordinates(string coordinates)
        {
            var regex = new Regex(@"(^[0-9]*\s[0-9]*\s[NWES]$)");
            return regex.IsMatch(coordinates ?? string.Empty);
        }

        public static bool ValidateCommands(string commands)
        {
            var rgx = new Regex(@"(^[LRM]+$)");
            return rgx.IsMatch(commands ?? string.Empty);
        }
    }
}
