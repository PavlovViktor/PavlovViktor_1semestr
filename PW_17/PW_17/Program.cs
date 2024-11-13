using System;
using System.IO;

class Program
{
    static void Main()
    {

        string[] colors = { "red", "green", "black", "white", "blue" };


        string filePath = @"C:\example\colors.txt";

        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string color in colors)
                {
                    writer.WriteLine(color);
                }
            }

            Console.WriteLine("Элементы массива успешно записаны в файл.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка при записи в файл: {ex.Message}");
        }
    }
}