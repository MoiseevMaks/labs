using System;


namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полиндром: ");
            string str = Console.ReadLine();
            
            if(Function.CheckingIfPolindrom(str))
            {
                Console.WriteLine("Строка является палиндромом");
            }
            else
            {
                Console.WriteLine("Строка  не является палиндромом");
            }
        }
    }
}
