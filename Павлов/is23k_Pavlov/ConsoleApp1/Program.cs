using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compare
{
    class Program
    {
        static void Main(string[] args)
        {

            ConcatString(); ;
            JoinString();
            CompareHalloWorld();
            FindInString();
            InsertString();
            DeleteString();
            ReplaceString();
            UpperLowerString();
        }
        static void ConcatString()
        {
            string s1 = "Привет, ";
            string s2 = "мир!";
            string s3 = s1 + " " + s2;
            string s4 = string.Concat(s3, "!!!");
            Console.WriteLine(s4);
        }
        static void JoinString()
        {
            string s5 = " каждый ";
            string s6 = " охотник ";
            string s7 = " xелает ";
            string s8 = " знать ";
            string s9 = " где сидит ";
            string s10 = " фaзaн ";
            string[] values = new string[] { s5, s6, s7, s8, s9, s10 };
            String s11 = String.Join(" ", values);
            Console.WriteLine(s11);
        }
        static void CompareHalloWorld()
        {
            string s1 = " Привет, ";
            string s2 = " Mup!";
            int result = String.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
        }
        static void FindInString()
        {
            string s1 = " Привет, мир!";
            char ch = 'т';
            int indexOfChar = s1.IndexOf(ch);
            Console.WriteLine("Индекс в строке символа {0} - {1}", ch, indexOfChar);
            string subString = "рив";
            int indexOfSubstring = s1.IndexOf(subString);
            Console.WriteLine("Индекс подстроки в строке {0} - {1}", subString, indexOfSubstring);
        }
        static void InsertString()
        {
            string text = "Задание выполнено";
            string subString = "не ";
            text = text.Insert(8, subString);
            Console.WriteLine(text);
        }
        static void DeleteString()
        {
            string text = "Задание выполнено";
            int ind = text.Length - 1;
            text = text.Remove(ind);
            Console.WriteLine(text);
            text = text.Remove(0, 2);
        }
        static void ReplaceString()
        {
            string text = "Солнечное утро";
            text = text.Replace("Coлнечное", "Дождливое");
            Console.WriteLine(text);
        }
        static void UpperLowerString()
        {
            string hello = "Привет, миp!";
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello.ToLower());
        }
    }
} 