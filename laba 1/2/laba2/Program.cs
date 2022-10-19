using System;


namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Кол-во строк?");
            int n;
            bool result1 =  int.TryParse(Console.ReadLine(), out n);
            if ((result1 == true) && n > 0)
            {
                for (int i = 0; i < n ; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {

                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Неверные значения ");
            }
            
        }
    }
}
