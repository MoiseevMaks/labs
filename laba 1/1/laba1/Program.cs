using System;


namespace laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, s;
            bool result1 = double.TryParse(Console.ReadLine(), out a);
            bool result2 = double.TryParse(Console.ReadLine(), out b);
            if (a <= 0 || b <= 0 || result1 == false || result2 == false)
            {
                Console.WriteLine("Неверные значения");
                return;
            }
            else
            {
                s = a * b;
                Console.WriteLine("s = {0}", s);
            }
        }
    }
}
