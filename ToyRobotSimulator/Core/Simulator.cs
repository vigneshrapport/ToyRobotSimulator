using System.Text.RegularExpressions;
using ToyRobotSimulator.Common.Enum;

namespace ToyRobotSimulator.Core
{
    public class Simulator
    {
        private readonly Table _table = new Table();
        private readonly Robot _robot = new Robot();

        public string ProcessCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                Console.WriteLine($"Unknown command");
                return string.Empty;
            }

            Match match = Regex.Match(command, @"^PLACE\s+(\d+),(\d+),(NORTH|EAST|SOUTH|WEST)$", RegexOptions.IgnoreCase);

            if (match.Success)
            {
                int x = int.Parse(match.Groups[1].Value);
                int y = int.Parse(match.Groups[2].Value);
                Direction facing = Enum.Parse<Direction>(match.Groups[3].Value.ToUpper());

                if (_table.IsValidPosition(x, y))
                {
                    _robot.Place(x, y, facing);
                }

                return string.Empty;
            }

            if (!_robot.IsPlaced)
            {
                Console.WriteLine("Robot is not placed on the table. Use PLACE command first.");
                return string.Empty;
            }

            Command _command = Enum.TryParse(command.ToUpper(), out Command parsedCommand) ? parsedCommand : Command.UNKNOWN;

            switch (_command)
            {
                case Command.MOVE:
                    (int nextX, int nextY) = GetNextPosition();
                    if (_table.IsValidPosition(nextX, nextY))
                        _robot.Move();
                    break;
                case Command.LEFT:
                    _robot.Left();
                    break;
                case Command.RIGHT:
                    _robot.Right();
                    break;
                case Command.REPORT:
                    Console.WriteLine($"Output:");
                    return _robot.Report();
                default:
                    Console.WriteLine($"Unknown command");
                    break;
            }
            return string.Empty;
        }

        private (int, int) GetNextPosition()
        {
            int x = _robot.X ?? 0;
            int y = _robot.Y ?? 0;
            switch (_robot.Facing)
            {
                case Direction.NORTH:
                    y++;
                    break;
                case Direction.EAST:
                    x++;
                    break;
                case Direction.SOUTH:
                    y--;
                    break;
                case Direction.WEST:
                    x--;
                    break;
            }
            return (x, y);
        }
    }
}