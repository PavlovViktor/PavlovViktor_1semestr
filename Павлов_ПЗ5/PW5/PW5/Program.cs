using System;

class Program
{
    static void Main()
    {
        double x = 4;
        double answer = SolveEquation(x);
        Console.WriteLine($"Решение уравнения 5*x^2 - 12*x + 4.6/-15*x при x={x} равно {answer}.");
    }

    private static double SolveEquation(double x)
    {
        double firstTerm = 5 * Math.Pow(x, 2);
        double secondTerm = -12 * x;
        double thirdTerm = 4.6 / (-15 * x);
        return firstTerm + secondTerm + thirdTerm;
    }
}