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
        public void move(int dx, int dy)
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
            if (telo[0].x == 60)
                telo[0].x = 0;
            if (telo[0].x < 0)
                telo[0].x = 59;
            if (telo[0].y == 30)
                telo[0].y = 0;
            if (telo[0].y < 0)
                telo[0].y = 29;
            for (int i = 1; i < telo.Count; i++)
            {
                if (telo[0].x == telo[i].x && telo[0].y == telo[i].y)
                {
                    Console.Clear();
                    Console.WriteLine("Game Over");
                    while (telo.Count > 0)
                        telo.RemoveAt(telo.Count-1);
                    telo.Add(new pair(0, 0));
                    Console.ReadKey();
                }
            }
        }
    }
}