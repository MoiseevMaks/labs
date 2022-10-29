using System.Text;
using System.Text.RegularExpressions;


namespace _4
{
    internal class Function
    {
        public static string ReplacingWithReg(string str)
        {
            string template = (@"<[^>]*>");
            string result1 = Regex.Replace(str, template, "_");
            return result1;
        }

        public static string ReplacingWithoutReg(string str)
        {
            int startIndex=0;
            int begin = 0;
            int end;
            var sb = new StringBuilder();
            while (str.IndexOf('<',startIndex) != -1)
            {
                if (str.IndexOf('>', startIndex) != -1)
                {
                    end = str.IndexOf('<', startIndex);
                    sb.Append(str.Substring(begin, end - begin));
                    sb.Append('_');
                    begin = str.IndexOf('>', startIndex) + 1;
                    startIndex = begin;
                }
                else break;
            }
            sb.Append(str.Substring(begin, str.Length - begin));
            string result2 = sb.ToString();
            return result2;
        }
    }
}
