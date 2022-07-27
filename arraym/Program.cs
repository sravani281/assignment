using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraym
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1= { 2, 4, 6 };
            Console.WriteLine("array1:[{0}]", string.Join(" ,", array1));
            int[] array2 = { -1, 0, 7 };
            Console.WriteLine("array1:[{0}]", string.Join(" ,", array2));
            int[] array3 = { 5, 6, 9 };
            Console.WriteLine("array1:[{0}]", string.Join(" ,", array3));
            int[] new_array = { array1[1], array2[1], array3[1] };
            Console.WriteLine("new array: [{0}]", string.Join(",", new_array));
        }
    }
}
