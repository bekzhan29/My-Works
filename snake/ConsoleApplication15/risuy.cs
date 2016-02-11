using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class risuy
    {
        public char ch;
        public ConsoleColor color;
        public List<pair> telo;
        public void naris()
        {
            foreach(pair cur in telo)
            {
                Console.SetCursorPosition(cur.x,cur.y);
                Console.Write(ch);
            }
            Console.SetCursorPosition(59, 29);
        }
    }
}
