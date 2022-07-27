using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter integer value");
            int a = Convert.ToInt32(Console.ReadLine());
            string b = Convert.ToString(a);
            Console.WriteLine("the string value is" + b);
            Console.WriteLine("enter string value");
            string s = Convert.ToString(Console.ReadLine());
            int t = Convert.ToInt32(s);
            Console.WriteLine("the int value is" + t);
        }
    }
}
