using System;
using System.Collections.Generic;
namespace Loop
{
    class ForEachLoop
    {
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i * 2 - 1;
            }
            Console.WriteLine("Сумма = {0}", sum);
        }
    }
}
