using System;
using Library1;
namespace z6
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            
            int[] array = new int[10];
            Library.Random1D(array);
            Console.Write("Массив : ");
            Library.Print1D(array);
            array = Tool.Function.DuplicationOfNegativeArrayElements(array);
            Console.Write("\nМассив с дублированными отрицательными числами : ");
            Library.Print1D(array);
            Console.ReadLine();
        }
    }
}
