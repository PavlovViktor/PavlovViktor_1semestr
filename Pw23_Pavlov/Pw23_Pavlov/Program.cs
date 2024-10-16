using System;
namespace Loop
{
    class ForEachLoop
    {
        public static void Main(string[] args)
        {
            double[] myArray = { 9, 10, 25, 31, 42, 47, 51, 74 };
            foreach (double i in myArray)
            {
                if (i > 20 && i < 50)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}