using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ascii
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("enter a alphabet");
            c = Convert.ToChar(Console.ReadLine());
            int ascii = c;
            Console.Write("the ascii value of " + c + " is : " + ascii);
        }
    }
}
