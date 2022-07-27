using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 4,7,2};
            Console.WriteLine("\n array1: [{0}]", string.Join(",", num));
            var temp = num[0];
            for (var i = 0; i < num.Length - 1;i++)
            {
                num[i] = num[i + 1];
            }
            num[num.Length - 1] = temp;
            Console.WriteLine("after rotating array:[{0}]", string.Join(",", num));
        }
    }
}
