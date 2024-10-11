namespace Test
{
    class BasicIO
    {
        static void Main()
        {
            long number;

            Console.WriteLine("Введите номер:");
            number = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(number.ToString("+# (####) ##-##-##"));
            Console.ReadKey();

        }
    }
}