using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace far
{
    class Program
    {
        static int sz = 0, cur = 0;
        static DirectoryInfo[] s = new DirectoryInfo[222];
        static DirectoryInfo[] dirs = new DirectoryInfo[222];
        DirectoryInfo root = new DirectoryInfo(@"C:\Users\Бекжан\Desktop\My-Works");
        public static void writedir(DirectoryInfo dir)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            if (sz > 0)
            {
                if (cur == -1)
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("..");
            }
            dirs = dir.GetDirectories();
            for (int i = 0; i < dirs.Length; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                if (i == cur)
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(dirs[i].Name);
            }
            Console.BackgroundColor = ConsoleColor.Black;
        }
        public static void writefile(DirectoryInfo dir)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (FileInfo f in dir.GetFiles())
                Console.WriteLine(f.Name);
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Бекжан\Desktop\My-Works");
            for(;;)
            {
                Console.Clear();
                writedir(dir);
                writefile(dir);
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key.ToString() == "Q")
                    break;
                if (key.Key.ToString() == "DownArrow")
                {
                    cur++;
                    if (cur == dirs.Length)
                        cur--;
                }
                if (key.Key.ToString() == "UpArrow")
                {
                    cur--;
                    if ((cur < 0 && sz == 0) || (cur < -1 && sz > 0))
                        cur++;
                }
                if (key.Key.ToString() == "Enter")
                {
                    if (cur == -1)
                    {
                        dir = s[sz--];
                        cur = -1;
                        if (sz == 0)
                            cur = 0;
                    }
                    else
                    {
                        s[++sz] = dir;
                        dir = dirs[cur];
                        cur = -1;
                    }
                }
            }
        }
    }
}