// Средний, минимальный и максимальный возраст в группе using System;
using System;
namespace среднее_значение_минимальный_и_максимальный_элементы
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ввод данных
            int n;
            Console.Write("Численность группы = ");
            n = Convert.ToInt32(Console.ReadLine()); int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Возраст {0}-го человека: ", i + 1);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }


            // Средний возраст
            double m = 0;
            for (int i = 0; i < n; i++)
                m = m + a[i];
            m = m / n; // Минимальный и максимальный возраст
            int min, max;
            min = a[0];
            max = a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
            }
            // Итоги
            Console.Write("ИТОГИ:\nВсего опрошено {0} \n", n);
            Console.WriteLine("средний возраст = {0}", m);
            Console.WriteLine("Минимальный возраст = {0};", min);
            Console.WriteLine("Максимальный возраст = {0}", max);
            Console.ReadKey();
        }
    }

}
