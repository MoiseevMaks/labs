using System;
using Library1;


namespace _9
{
    internal class Program
    {
        


        static void Main(string[] args)
        {

            int[] array1 = new int[3];
            int[] array2 = new int[3];
            Console.WriteLine("Первый массив ");
            Library.FillingArray(array1);
            Console.WriteLine("Второй массив ");
            Library.FillingArray(array2);
            Console.Write("Первый ");
            Library.Print1D(array1);
            Console.Write("\nВторой ");
            Library.Print1D(array2);
            if (Tool.Function.Compairing(array1, array2))
            {
                Console.WriteLine("\nМассивы одинаковы");
            }
            else
            {
                Console.WriteLine("\nМассивы не одинаковы");
            }
            Console.ReadLine();
        }
    }
}
