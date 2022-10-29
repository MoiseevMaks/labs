using System;



namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if(Function.CheckingEmail(str))
            {
                Console.WriteLine("Строка является почтой");
            }
            else
            {
                Console.WriteLine("Строка не является почтой");
            }
        }
    }
}
