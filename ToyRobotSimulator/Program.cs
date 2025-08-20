using ToyRobotSimulator.Core;

namespace ToyRobotSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Simulator simulator = new Simulator();
            Console.WriteLine("Toy Robot Simulator.");
            Console.WriteLine("\nSample acceptable command format:");
            Console.WriteLine("  PLACE X,Y,F");
            Console.WriteLine("    - X and Y specify the robot's position on the table.");
            Console.WriteLine("    - F specifies the facing direction: NORTH, SOUTH, EAST, or WEST.");
            Console.WriteLine();
            Console.WriteLine("\nOther commands:");
            Console.WriteLine("  MOVE    - Move forward one unit in the current facing direction");
            Console.WriteLine("  LEFT    - Rotate left 90 degrees");
            Console.WriteLine("  RIGHT   - Rotate right 90 degrees");
            Console.WriteLine("  REPORT  - Output the robot’s current position and facing direction");
            Console.WriteLine("\nEnter commands (or Ctrl+C to exit):");
            string? line;
            while ((line = Console.ReadLine()) != null)
            {
                string output = simulator.ProcessCommand(line?.Trim());
                if (!string.IsNullOrEmpty(output))
                    Console.WriteLine(output);
            }
        }
    }
}
