using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LW_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int t = 0, N = 1;
            double X = 0, Y = 0, A = 0;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());

            int i = 1, Xstep = 1, Ystep = 1;
            double znam = 1, chisl;

            if (t == 0)
            {
                for (i = 1; i <= N; i++)
                {
                    if (i % 2 != 0)
                        chisl = -Math.Sin(Math.Pow(X, Xstep)) * Math.Log10(Math.Pow(Y, Ystep));
                    else
                        chisl = Math.Log(Math.Pow(X, Xstep)) * Math.Cos(Math.Pow(Y, Ystep));
                    A += chisl / znam;
                    Xstep += 2;
                    Ystep += 1;
                    znam *= (Xstep - 1) * Xstep;
                }
            }

            if (t == 1)
            {
                i = 1;
                while (i <= N)
                {
                    if (i % 2 != 0)
                        chisl = -Math.Sin(Math.Pow(X, Xstep)) * Math.Log10(Math.Pow(Y, Ystep));
                    else
                        chisl = Math.Log(Math.Pow(X, Xstep)) * Math.Cos(Math.Pow(Y, Ystep));
                    A += chisl / znam;
                    Xstep += 2;
                    Ystep += 1;
                    znam *= (Xstep - 1) * Xstep;
                    i++;
                }
            }

            if (t == 2)
            {
                i = 1;
                do
                {
                    if (i % 2 != 0)
                        chisl = -Math.Sin(Math.Pow(X, Xstep)) * Math.Log10(Math.Pow(Y, Ystep));
                    else
                        chisl = Math.Log(Math.Pow(X, Xstep)) * Math.Cos(Math.Pow(Y, Ystep));
                    A += chisl / znam;
                    Xstep += 2;
                    Ystep += 1;
                    znam *= (Xstep - 1) * Xstep;
                    i++;
                } while (i <= N);
                
            }

            Console.WriteLine(String.Format("{0:0.0000000}", A));

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
