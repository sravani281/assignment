using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string s = Convert.ToString(Console.ReadLine());
            char[] ch = s.ToCharArray();
            StringBuilder ab = new StringBuilder();
            char[] c = new char[s.Length];
            int j = 0;
            for(int i =0;i<s.Length;i++)
            {
                if (!((int)ch[i] >= 48 && (int)ch[i] <= 57))
                    c[j++] = ch[i];

            }
            string m = new string(c);
            Console.WriteLine(m);
        }
    }
}
