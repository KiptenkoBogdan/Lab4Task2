using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A(3, 4);
            B obj2 = new B(13, 14, 15);
            Console.WriteLine("Vlastyvist c2 (a + b + d)= {0}", obj2.c2);
            Console.ReadKey();
        }
    }
}
