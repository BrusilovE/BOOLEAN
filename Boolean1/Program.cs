using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool s;
            int a;
            Console.Write("введите целое число = ");
            a = Convert.ToInt32(Console.ReadLine());
            s = a > 0;  
            Console.Write("число является положительным = " + s );
            Console.ReadLine();
        }
    }
}
