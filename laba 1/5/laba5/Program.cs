using System;


namespace laba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int max = 1000;
            for(int i = 0; i < max; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    s += i;
                }
            }
            Console.WriteLine("Сумма чисел кратных 3 или 5 от 0 до 1000 = " + s);
        }
    }
}
