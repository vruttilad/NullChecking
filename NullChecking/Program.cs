using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullChecking
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "welcome to the world of friends";
            string s2 = "";
            string s3 = string.Empty;

            bool b1 = string.IsNullOrEmpty(s1);
            bool b2 = string.IsNullOrEmpty(s2);
            bool b3 = string.IsNullOrEmpty(s3);
            Console.WriteLine(b1);
            Console.ReadLine();
            Console.WriteLine(b2);
            Console.ReadLine();
            Console.WriteLine(b3);
            Console.ReadLine();

        }
    }
}
