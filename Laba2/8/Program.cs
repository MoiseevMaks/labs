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
            array = Tool.Function.SearchElement(array);
            Library.Print1D(array);
        }
    }
}