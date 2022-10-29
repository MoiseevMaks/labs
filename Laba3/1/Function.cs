using System;


namespace _1
{
    internal class Function
    {
        public static double CountWordLength(string str)
        {
            
            double sum = 0;
            double ammount = 0;
            char[] symbols = new char[] { ' ', ',', '.', '?', '-', ';', ':', '!' };
            string[] substr = str.Split(symbols, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < substr.Length; i++)
            {
                sum += substr[i].Length;
                ammount++;
            }
            double sredSum = sum / ammount;
            return sredSum;
        }
    }
}
