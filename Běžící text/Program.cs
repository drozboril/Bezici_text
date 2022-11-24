using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Běžící_text
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej větu");
            string str = Console.ReadLine();
            int x = 80, y = 10;
            int d = str.Length;
            int r = 100;
            Console.CursorVisible = false;
            Console.Clear();
            Console.SetWindowSize(x, y);
            while (Console.KeyAvailable == false)
            {
                for (int a = x-d; a > 0; a--)
                {
                 Console.SetCursorPosition(a, y/2);
                 Console.BackgroundColor = ConsoleColor.DarkBlue;
                 Console.ForegroundColor = ConsoleColor.Yellow;
                 Console.WriteLine(str);
                 Thread.Sleep(r);
                 Console.Clear();
                    if (Console.KeyAvailable == true) break;
                }
            Console.ReadLine();
            }
        }
    }
}