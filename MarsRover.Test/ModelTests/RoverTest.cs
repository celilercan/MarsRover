using MarsRover.Common.Enums;
using MarsRover.Common.Models;
using System;
using Xunit;

namespace MarsRover.Test.ModelTests
{
    public class RoverTest
    {
        [Fact]
        public void RoverRun_ShouldNullReferenceException_WhenCommandsIsNull()
        {
            var rover = new Rover();
            var result = Record.Exception(() => rover.Run(null));
            Assert.NotNull(result);
            Assert.IsType<NullReferenceException>(result);
        }

        [Fact]
        public void RoverRun_ShouldDefaultValues_WhenIncorrectCoordinates_And_WhenIncorrectCommands()
        {
            var rover = new Rover("A B C");
            rover.Run("ABCD");

            Assert.Equal(default(int), rover.X);
            Assert.Equal(default(int), rover.Y);
            Assert.Equal(Direction.North, rover.Direction);
        }

        [Fact]
        public void RoverRun_ShouldCorrectCoordinates_WhenCommandsIsNotNull()
        {
            var rover = new Rover("1 2 N");
            rover.Run("LMLMLMLMM");

            Assert.Equal(1, rover.X);
            Assert.Equal(3, rover.Y);
            Assert.Equal(Direction.North, rover.Direction);
        }
    }
}
