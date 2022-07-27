using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multable
{
    class Program 
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write("enter a number :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            for (i=1;i<10;i++)
            {
                Console.WriteLine(" {0} * {1} = {2} " , a, i, a * i);
            }
            Console.Read();

        }
    }
}
