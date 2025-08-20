using ToyRobotSimulator.Common.Enum;

namespace ToyRobotSimulator.Core
{
    public class Robot
    {
        public int? X { get; private set; }
        public int? Y { get; private set; }
        public Direction? Facing { get; private set; }
        public bool IsPlaced => X.HasValue && Y.HasValue && Facing.HasValue;

        public void Place(int x, int y, Direction facing)
        {
            X = x;
            Y = y;
            Facing = facing;
        }

        public void Move()
        {
            if (!IsPlaced)
            {
                Console.WriteLine("Robot is not placed on the table.");
                return;
            }

            switch (Facing)
            {
                case Direction.NORTH:
                    Y++;
                    break;
                case Direction.EAST:
                    X++;
                    break;
                case Direction.SOUTH:
                    Y--;
                    break;
                case Direction.WEST:
                    X--;
                    break;
                default:
                    throw new InvalidOperationException("Invalid direction.");
            }
        }

        public void Left()
        {
            if (!IsPlaced)
            {
                Console.WriteLine("Robot is not placed on the table.");
                return;
            }
            Facing = (Direction)(((int)Facing + 3) % 4);
        }

        public void Right()
        {
            if (!IsPlaced)
            {
                Console.WriteLine("Robot is not placed on the table.");
                return;
            }
            Facing = (Direction)(((int)Facing + 1) % 4);
        }

        public string Report()
        {
            if (!IsPlaced)
            {
                Console.WriteLine("Robot is not placed on the table.");
                return string.Empty;
            }
            return $"{X},{Y},{Facing}";
        }
    }
}