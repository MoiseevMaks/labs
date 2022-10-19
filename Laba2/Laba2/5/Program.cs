using System;
using Library1;

namespace z5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Library.Random1D(array);
            Console.Write("Массив : ");
            Library.Print1D(array);
            array = Tool.Function.RemovingAllNegativeElementsInArray(array);
            Console.Write("\nМассив без отрицательных чисел : ");
            Library.Print1D(array);
            Console.ReadLine();
        }
    }
}