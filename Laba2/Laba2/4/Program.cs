using System;
using Library1;


namespace z4
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            int[,] array = new int[3, 4];
            Tool.Function.Random2D(array);
            Tool.Function.Print2D(array);
            Console.WriteLine("S = " + Tool.Function.SumElementsOfEvenPositions(array));
        }
    }

}

