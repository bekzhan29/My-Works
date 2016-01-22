using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            foreach (string t in s)
            {
                int a = Convert.ToInt32(t), ch = 0;
                for (int i = 2; i * i <= a; i++)
                    if (a % i == 0)
                        ch = 1;
                if (ch == 0)
                    Console.Write(a + " ");
            }
            Console.ReadKey();
        }
    }
}
