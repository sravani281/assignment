using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first integer");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second integer");
            int y = Convert.ToInt32(Console.ReadLine());
            if( (x > 0 && y<0)|| (x < 0 && y > 0))
            {
                Console.WriteLine("correct input");
            }
            else
                {
                Console.WriteLine("wrong input");
            }

        }
    }
}
