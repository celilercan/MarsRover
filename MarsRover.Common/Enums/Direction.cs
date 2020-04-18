using MarsRover.Common.Attributes;

namespace MarsRover.Common.Enums
{
    public enum Direction
    {
        [ShortCode("N")]
        North = 1,

        [ShortCode("S")]
        South = 2,

        [ShortCode("E")]
        East = 3,

        [ShortCode("W")]
        West = 4
    }
}
