using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_7
{
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"seg_output.txt");
            var new_in = new StreamReader(@"seg_input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif
            Segment s1, s2;
#if DEBUG 
            s2 = new Segment(1, 2, 3, 4);
            s2.Info(ConsoleColor.Red, ConsoleColor.Black);
#endif

#if !DEBUG
            s1 = Segment.CreateSegmentFromFile();
            s1.Info();
            s2 = new Segment(5, 6, 7, 8);
            s2.Info();
#endif

#if !DEBUG
            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
#endif

#if DEBUG
            Console.ReadKey();
#endif
        }
    }
}
