using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class igra
    {
        public int vigre;
        public snake jilan = new snake();
        public eda alma = new eda();
        public igra()
        {
            vigre = 1;
            jilan.telo.Add(new pair(0, 0));
            Random rand = new Random();
            alma.pos.x = rand.Next(60);
            alma.pos.y = rand.Next(30);
        }
        public void check()
        {
            if (jilan.telo[0].x == alma.pos.x && jilan.telo[0].y == alma.pos.y)
            {
                jilan.telo.Add(new pair(jilan.last.x,jilan.last.y));
                Random rand = new Random();
                while(true)
                {
                    alma.pos.x = rand.Next(60);
                    alma.pos.y = rand.Next(30);
                    int cnt = 0;
                    foreach(pair cur in jilan.telo)
                    {
                        if (alma.pos.x == cur.x && alma.pos.y == cur.y)
                            cnt++;
                    }
                    if (cnt == 0)
                        break;
                }
            }
        }
    }
}
