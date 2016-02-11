using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class eda
    {
        public pair pos = new pair();
        public char ch;
        public eda()
        {
            ch = '☺';
            pos.x = pos.y = 0;
        }
        public void naris()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write(ch);
            Console.SetCursorPosition(59, 29);
        }
    }
}
