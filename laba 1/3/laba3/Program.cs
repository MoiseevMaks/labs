using System;


namespace laba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кол-во строк?");
            int n, space, star = 1;
            bool result1 = int.TryParse(Console.ReadLine(), out n);
            space = n;
            if ((result1 == true) && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < space; j++)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 0; j < star; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    space--;
                    star += 2;
                }
            }
            else
            {
                Console.WriteLine("Неверные данные");
            }
        }
    }
}
