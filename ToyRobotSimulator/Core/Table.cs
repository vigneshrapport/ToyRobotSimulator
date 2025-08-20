namespace ToyRobotSimulator.Core
{
    public class Table
    {
        public int Width { get; }
        public int Height { get; }

        public Table(int width = 5, int height = 5)
        {
            Width = width;
            Height = height;
        }

        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < Width && y >= 0 && y < Height;
        }
    }
}