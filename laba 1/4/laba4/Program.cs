using System;


namespace laba4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n, space, s, strok;
            Console.Write("Кол-во треугольников  ");
            bool result1 = int.TryParse(Console.ReadLine(), out n);
            strok = 1;
            if ((result1 == true) && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    space = n;
                    s = 1;
                    for (int m = 0; m < strok; m++)
                    {
                        for (int j = 0; j < space; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int k = 0; k < s; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        space--;
                        s += 2;
                    }
                    strok++;
                }
            }
            else
            {
                Console.WriteLine("Неверные данные");
            }
        }
    }
}