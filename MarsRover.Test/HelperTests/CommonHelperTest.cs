using MarsRover.Common.Helpers;
using System;
using Xunit;

namespace MarsRover.Test.HelperTests
{
    public class CommonHelperTest
    {
        [Fact]
        public void ValidateCoordinates_ShouldFalse_WhenCoordinatesIsNull()
        {
            var validationResult = CommonHelper.ValidateCoordinates(null);
            Assert.False(validationResult);
        }

        [Fact]
        public void ValidateCoordinates_ShouldFalse_WhenIncorrectFormat()
        {
            var validationResult = CommonHelper.ValidateCoordinates("ABC");
            Assert.False(validationResult);
        }

        [Fact]
        public void ValidateCoordinates_ShouldTrue_WhenCorrectFormat()
        {
            var validationResult = CommonHelper.ValidateCoordinates("1 2 N");
            Assert.True(validationResult);
        }

        [Fact]
        public void ValidateCommands_ShouldFalse_WhenCommandsIsNull()
        {
            var validationResult = CommonHelper.ValidateCommands(null);
            Assert.False(validationResult);
        }

        [Fact]
        public void ValidateCommands_ShouldFalse_WhenIncorrectFormat()
        {
            var validationResult = CommonHelper.ValidateCommands("l m K 2");
            Assert.False(validationResult);
        }

        [Fact]
        public void ValidateCommands_ShouldTrue_WhenCorrectFormat()
        {
            var validationResult = CommonHelper.ValidateCommands("LMLMLMLMM");
            Assert.True(validationResult);
        }
    }
}
