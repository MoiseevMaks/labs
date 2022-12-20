using System;
using Library1;


namespace z8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Library.CreatingArray();
            Tool.Function.Random1D(array);
            Library.Print1D(array);
            Console.Write("\nИскомое значение = ");
            bool result1 = int.TryParse(Console.ReadLine(), out int number);
            if (result1)
            {
                array = Tool.Function.SearchElement(array, number);
                Library.Print1D(array);
            }
            else
            {
                Console.WriteLine("Неправильный ввод");
            }
           
        }
    }
}