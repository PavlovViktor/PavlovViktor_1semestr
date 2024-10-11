namespace Test
{
    class BasicIO
    {
        static void Main()
        {
            Console.Title = "Средства форматирования строк в C#";
            string TheString = "Добрый день";
            int theInt = 17;
            float theFloat = 12.88F;
            double theDouble = 123.456789;
            BasicIO theClass = new BasicIO();
            //Вывод
            Console.WriteLine("Без параметров форматирования");
            Console.WriteLine("string: {0}\nint: {1}\nfloat: {2}\ndouble: {3}\nobject: {4}",
                TheString, theInt,
                theFloat, theDouble,
                theClass);
            Console.Write("\n\n");

            //Форматирования массива
            object[] array = { "Привет!", 20.9, 12, "77", Math.PI };
            Console.WriteLine("Элементы массива:\n{0}; {1}; {2}; {3}; {4}", array);
            Console.Write("\n\n");

            //Форматирование с параметрами
            Console.WriteLine("С параметрами форматирования:");
            Console.WriteLine("C format: {0:C}", 99989.987);
            Console.WriteLine("D9 format: {0:D9}", 99999);
            Console.WriteLine("E format: {0:E}", .31415926538 * 10);
            Console.WriteLine("F format: {0:F3}", 55555.6666);
            Console.WriteLine("N format: {0:N}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("x format: {0:x}", 99999);
            Console.Write("\n\n");

            //Предварительное форматирование в символьную строку
            string str;
            str = String.Format("C format: {0:C}", 99989.987);
            Console.WriteLine("Предварительное форматирование в символьную строку:");

            Console.WriteLine(str);

            str = "ФИО: {{ {0} }}, Возраст {{ {1} }}";
            str = String.Format(str, "Васильева В.М.", 19);
            Console.Write("\n\nПредварительное форматирование в символьную строку: ");
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}