using System;


namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "<b>Это</b> текст <i>с</i> <font color=”red”>HTML</font> кодами";
            Console.WriteLine(Function.ReplacingWithReg(str));
            Console.WriteLine(Function.ReplacingWithoutReg(str));

        }
    }
}
