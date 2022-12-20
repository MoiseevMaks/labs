using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace _1
{
    
    internal class Program
    {

        static void Main(string[] args)
        {
            var user = new User("Aaa", "Bbb", "ddddd", DateTime.Parse("2003.09.07"));
            Console.WriteLine(user.ToString());
            string a = "aaa, Cccc, Dddd, 23f@mail.ru, 07.09.2003";
            user.FillFromString(a);
            Console.WriteLine(user.ToString());
            Console.ReadKey();
        }
    }
}
