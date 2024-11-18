using System;

class Program
{
    static void Main()
    {
        string s = "Я скоро поеду на научную конференцию в Курск";
        int index = s.IndexOf("Курск");
        Console.WriteLine($"Индекс слова 'Курск': {index}");
        s = s.Replace("в Курск", "");
        Console.WriteLine($"После удаления 'в Курск': {s}");
        s = s.Replace("научную конференцию", "соревнование");
        Console.WriteLine($"После замены 'научную конференцию' на 'соревнование': {s}");
        Console.WriteLine($"Весь текст в верхнем регистре: {s.ToUpper()}");
    }
}