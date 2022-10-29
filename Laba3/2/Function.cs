using System;
using System.Text;



namespace _2
{
    internal class Function
    {
        public static bool CheckingIfPolindrom(string str)
        {
            char[] str1 = str.ToUpper().ToCharArray();
            var polindrom = new StringBuilder();
            for(int i = 0; i < str1.Length; i++)
            {
                if(char.IsLetter(str[i]))
                {
                    polindrom.Append(str[i]);
                }
            }
            char[] str2 = polindrom.ToString().ToCharArray();
            Array.Reverse(str2);
            string reversedPolin = new string(str2);
            if(polindrom.ToString() == reversedPolin)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
