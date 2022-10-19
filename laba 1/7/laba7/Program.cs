using System;

namespace laba7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte first, second;
            Console.Write("Введите первое число : ");

            bool result1 = byte.TryParse(Console.ReadLine(), out first);
            Console.Write("Введите второе число : ");
            bool result2 = byte.TryParse(Console.ReadLine(), out second);
            if (result1 == true && result2 == true)
            {
                Console.WriteLine("Побитовое И чисел {0} и {1} = {2}", first, second, first & second);
                Console.WriteLine("Побитовое ИЛИ чисел {0} и {1} = {2}", first, second, first | second);
                Console.WriteLine("Побитовое исключающее ИЛИ чисел {0} и {1} = {2}", first, second, first ^ second);
            }
            else
            {
                Console.WriteLine("Неправильно введены данные");
            }
        }
    }
}
