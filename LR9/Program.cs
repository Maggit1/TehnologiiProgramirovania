using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_9
{             
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            Console.Title = ("Лабораторная работа №9");

            Video v = new Video("Queen Official", "LIVE AT WEMBLEY", 926);
            v.Up(7);
            v.Down(1);
            v.DrawContent();

            Console.WriteLine("\n\n\n");

            Photo ph = new Photo("Axl Rose", "Los Angeles", 837);
            ph.Up(16);
            ph.Down(5);
            ph.DrawContent();

            Console.ReadKey();
        }
    }
}