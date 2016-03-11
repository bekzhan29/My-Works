using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class snake : risuy
    {
        public pair last;
        public snake()
        {
            last = new pair();
            color = ConsoleColor.DarkGreen;
            ch = '⌂';
            telo = new List<pair>(1111);
        }
        public void nariss()
        {
            if (last.x + last.y >= 0)
            {
                Console.SetCursorPosition(last.x, last.y);
                Console.Write(" ");
            }
            Console.SetCursorPosition(telo[0].x, telo[0].y);
            Console.Write(ch);
            Console.SetCursorPosition(59, 29);
        }
        public int move(int dx, int dy)
        {
            last.x = telo[telo.Count - 1].x;
            last.y = telo[telo.Count - 1].y;
            for (int i = telo.Count - 1; i > 0; i--)
            {
                telo[i].x = telo[i - 1].x;
                telo[i].y = telo[i - 1].y;
            }
            telo[0].x += dx;
            telo[0].y += dy;
            telo[0].x = (telo[0].x + 60) % 60;
            telo[0].y = (telo[0].y + 30) % 30;
            for (int i = 1; i < telo.Count; i++)
            {
                if (telo[0].x == telo[i].x && telo[0].y == telo[i].y)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over");
                    while (telo.Count > 0)
                        telo.RemoveAt(0);
                    telo.Add(new pair(0, 0));
                    Console.ReadKey();
                    Console.Clear();
                    return 0;
                }
            }
            return 1;
        }
    }
}