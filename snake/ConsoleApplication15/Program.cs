using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 30);
            igra igra = new igra();
            igra.jilan.naris();
            igra.alma.naris();
            while (igra.vigre == 1)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.ToString() == "UpArrow")
                    igra.jilan.move(0, -1);
                if (key.Key.ToString() == "DownArrow")
                    igra.jilan.move(0, 1);
                if (key.Key.ToString() == "LeftArrow")
                    igra.jilan.move(-1, 0);
                if (key.Key.ToString() == "RightArrow")
                    igra.jilan.move(1, 0);
                igra.check();
                Console.Clear();
                igra.jilan.naris();
                igra.alma.naris();
            }
            Console.ReadKey();
        }
    }
}
