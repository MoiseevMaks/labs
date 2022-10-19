using System;
using Library1;

namespace z3
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            int[] array = new int[10];
            Library.Random1D(array);
            Library.Print1D(array);
            Console.WriteLine("\nS = " + Tool.Function.SumPositiveNumbers(array));
            Console.ReadKey();
        }
    }
}
