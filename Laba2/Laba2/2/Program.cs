
using System;
namespace Z2
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            int[,,] array = new int[4, 5, 5];
            Tool.Function.Random3D(array);
            Console.WriteLine("Созданный массив: ");
            Tool.Function.Print3D(array);
            Tool.Function.ReplacingPositiveOnZero(array);
            Tool.Function.Print3D(array);
            Console.ReadLine();
        }
    }
}