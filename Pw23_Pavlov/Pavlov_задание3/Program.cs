// See httpusing System;
namespace Loop
{
    class ForEachLoop
    {
        static void Main(string[] args)
        {
            int xStart = 2, xEnd = 8;
            int yStart = 2, yEnd = 5;

            for (int x = xStart; x <= xEnd; x++)
            {
                for (int y = yStart; y <= yEnd; y++)
                {
                    int z = x * y;
                    Console.WriteLine($"z({x}, {y})={z}");
                }
            }
        }
    }
}
