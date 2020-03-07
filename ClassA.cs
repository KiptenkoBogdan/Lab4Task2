using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task2
{
    public class A
    {
        public int a;
        public int b;
        public A(int x, int y)
        {
            this.a = x;
            this.b = y;
            Console.WriteLine("a = {0}", this.a);
            Console.WriteLine("b = {0}", this.b);
        }
    }
}
