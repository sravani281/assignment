using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, temp;
            Console.Write("enter  first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            number2 = Convert.ToInt32(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.WriteLine("\n first number:" +number1);
            Console.WriteLine("\n second number:" +number2);
            Console.Read();
        }
    }
}
