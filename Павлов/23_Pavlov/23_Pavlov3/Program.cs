namespace Test
{
    class BasicIO
    {
        static void Main()
        {
            Console.Write("«Курский государственный политехнический колледж» \nКонтактная информация");

            string str;

            str = "\nКонтактные телефоны: {0}\nКонтактный факс: {1} ";
            str = String.Format(str, " +7 (4712) 37-02-19", " +7 (4712) 37-02-19");
            Console.WriteLine(str);
            Console.ReadKey();

        }
    }
}