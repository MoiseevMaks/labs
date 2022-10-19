using System;


namespace laba6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, p, s;
            Console.Write(" a = ");
            bool result1 = double.TryParse(Console.ReadLine(), out a);
            Console.Write(" b = ");
            bool result2 = double.TryParse(Console.ReadLine(), out b);
            Console.Write(" c = ");
            bool result3 = double.TryParse(Console.ReadLine(), out c);
            if (result1 == true && result2 == true && result3 == true)
            {
                if (a > b + c || b > c + a || c > a + b || a <= 0 || b <= 0 || c <= 0)
                {
                    Console.WriteLine("Треугольник не существуют");
                    return;
                }
                else
                {
                    p = (a + b + c) / 2;
                    s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                    Console.WriteLine("S = " + s);
                }
            }
            else
            {
                Console.WriteLine("Неправильно введены данные");
            }
            
        }
    }
}
