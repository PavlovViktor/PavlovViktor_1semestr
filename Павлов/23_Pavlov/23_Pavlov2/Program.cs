namespace Test
{
    class BasicIO
    {
        static void Main()
        {
            string str;

            str = "Фамилия: {0}\nДата рождения: {1} \nМесто рождения: {2}\nВозраст: {3}";
            str = String.Format(str, "Васильева", "22.02.2005", "г.Курск", 19);
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}