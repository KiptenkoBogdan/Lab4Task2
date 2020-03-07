using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Task2
{
    public class B: A
    {
        public int d;
        public B(int x, int y, int z):base(x, y)
        {
            this.d = z;
            Console.WriteLine("d = {0}", this.d);
        }
        public int c2
        {
            get
            { 
                return a + b + d; 
            }
        }
    }
}
