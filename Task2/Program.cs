using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = "";
            str = str.Replace(" ", "");
            foreach (char c in str)
            {
                str2 = c + str2;
            }
            Console.WriteLine(str2);
            if (str == str2)
            {
                Console.WriteLine("Данная строка является палиндромом");
            }
            if (str != str2)
            {
                Console.WriteLine("Данная строка не является палиндромом");
            }
            Console.ReadKey();
        }
    }
}
