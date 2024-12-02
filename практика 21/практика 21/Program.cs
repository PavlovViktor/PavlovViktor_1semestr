using System;


public class AverageMethods
{
   
    public static double Average(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Массив не может быть пустым или равен null", nameof(numbers));

        int sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }

        return (double)sum / numbers.Length;
    }

   
    public static double Average(float[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Массив не может быть пустым или равен null", nameof(numbers));

        float sum = 0; // Автоматически преобразуется в float
        foreach (var number in numbers)
        {
            sum += number;
        }

        return (double)sum / numbers.Length;
    }
}