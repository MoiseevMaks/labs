using System;
using System.Text.RegularExpressions;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:  ");
            string str = Console.ReadLine();
            foreach (Match m in Functions.PrintDate(str))
            {
                Console.WriteLine("{0},где день = {1}, месяц = {2}, год = {3}",
                    m.Value, m.Groups["day"], m.Groups["month"], m.Groups["year"]);
            }

        }
    }
}
