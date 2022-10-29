using System.Text.RegularExpressions;

namespace _3
{
    internal class Function
    {
        public static bool CheckingEmail(string str)
        {
            Regex reg = new Regex(@"^[a-zA-Z0-9](?:[\w\-\.]*[a-zA-Z0-9])?@(?:[a-zA-Z0-9](?:[\w\-]*[a-zA-Z0-9])?\.){1,}[a-zA-Z]{2,6}$", RegexOptions.IgnoreCase);
            MatchCollection mc = reg.Matches(str);
            foreach (Match match in mc)
            {
                return true;
            }
            return false;
        }
    }
}
