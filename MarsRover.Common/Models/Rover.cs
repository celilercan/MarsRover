using MarsRover.Common.Enums;
using MarsRover.Common.Extensions;
using MarsRover.Common.Helpers;

namespace MarsRover.Common.Models
{
    public class Rover
    {
        public Rover()
        {
            this.X = default(int);
            this.Y = default(int);
            this.Direction = Direction.North;
        }

        public Rover(string combinedCoordinates)
        {
            var coordinates = this.CoordinateResolver(combinedCoordinates);
            this.X = coordinates.X;
            this.Y = coordinates.Y;
            this.Direction = coordinates.Direction;
        }

        public int X { get; set; }

        public int Y { get; set; }

        public Direction Direction { get; set; }

        public void Run(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case 'L':
                        this.ToLeft();
                        break;
                    case 'R':
                        this.ToRight();
                        break;
                    case 'M':
                        this.Move();
                        break;
                    default:
                        break;
                }
            }
        }

        private void ToLeft()
        {
            switch (this.Direction)
            {
                case Direction.North:
                    this.Direction = Direction.West;
                    break;
                case Direction.South:
                    this.Direction = Direction.East;
                    break;
                case Direction.East:
                    this.Direction = Direction.North;
                    break;
                case Direction.West:
                    this.Direction = Direction.South;
                    break;
                default:
                    break;
            }
        }

        private void ToRight()
        {
            switch (this.Direction)
            {
                case Direction.North:
                    this.Direction = Direction.East;
                    break;
                case Direction.South:
                    this.Direction = Direction.West;
                    break;
                case Direction.East:
                    this.Direction = Direction.South;
                    break;
                case Direction.West:
                    this.Direction = Direction.North;
                    break;
                default:
                    break;
            }
        }

        private void Move()
        {
            switch (this.Direction)
            {
                case Direction.North:
                    this.Y++;
                    break;
                case Direction.South:
                    this.Y--;
                    break;
                case Direction.East:
                    this.X++;
                    break;
                case Direction.West:
                    this.X--;
                    break;
                default:
                    break;
            }
        }

        private (int X, int Y, Direction Direction) CoordinateResolver(string combinedCoordinates)
        {
            if (CommonHelper.ValidateCoordinates(combinedCoordinates))
            {
                var coordinates = combinedCoordinates.Split();
                return (X: coordinates[0].ToIntOrDefault(), Y: coordinates[1].ToIntOrDefault(), Direction: coordinates[2].GetDirection());
            }

            return (X: default(int), Y: default(int), Direction: Direction.North);
        }
    }
}
