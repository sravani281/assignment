using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adding
{
    class Program
    {
        static void Main(string[] args)
        {
            int num3;
            Console.Write("enter a firsrt number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("addition :" +(num1 + num2));
            Console.WriteLine("subtract :" + (num1 - num2));
            Console.WriteLine("multiply :" + (num1 * num2));
            Console.WriteLine("division :" + (num1 / num2));

        }
    }
}
