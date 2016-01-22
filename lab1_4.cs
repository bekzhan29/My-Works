using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class complex
    {
        public int a, b;
        public complex()
        {
            this.a = 0;
            this.b = 1;
        }
        public complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static complex operator +(complex a, complex b)
        {
            complex c = new complex();
            c.b = a.b * b.b;
            c.a = a.a * b.b + b.a * a.b;
            return c;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine()), y = Convert.ToInt32(Console.ReadLine());
            complex a = new complex(x,y);
            complex b = new complex(22, 7);
            Console.WriteLine(a + b);
            Console.ReadKey();
        }
    }
}