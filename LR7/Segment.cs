using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_7
{
    class Segment
    {
        private double x0, y0, x, y;

        private Segment() { }

        public Segment(double sX0, double sY0, double sX, double sY)
        {
            x0 = sX0; y0 = sY0; x = sX; y = sY;
        }
        
        private void Load()
        {
            x0 = Convert.ToDouble(Console.ReadLine());
            y0 = Convert.ToDouble(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
        }

        public static Segment CreateSegmentFromFile()
        {
            double xx0 = Convert.ToDouble(Console.ReadLine());
            double yy0 = Convert.ToDouble(Console.ReadLine());
            double xx = Convert.ToDouble(Console.ReadLine());
            double yy = Convert.ToDouble(Console.ReadLine());
            return new Segment(xx0, yy0, xx, yy);
        }
        
        public double GetLength() { return Math.Sqrt(Math.Pow((x - x0), 2) + Math.Pow((y - y0), 2)); }

        public double GetDistanceToStart() { return Math.Sqrt(Math.Pow((x0), 2) + Math.Pow((y0), 2)); }

        public double GetDistanceToEnd() { return Math.Sqrt(Math.Pow((x), 2) + Math.Pow((y), 2)); }

        public void Info()
        {
            String str = "\n*       Отрезок в пространстве       *";
            Console.WriteLine(str);
            
            Console.WriteLine(string.Format("x0 = {0:0.00}", x0));
            Console.WriteLine(string.Format("y0 = {0:0.00}", y0));
            Console.WriteLine(string.Format("x = {0:0.00}", x));
            Console.WriteLine(string.Format("y = {0:0.00}", y));

            Console.WriteLine(string.Format("Длина отрезка = {0:0.00}", GetLength()));
            Console.WriteLine(string.Format("Расстояние от начала координат до начала отрезка = {0:0.00}", GetDistanceToStart()));
            Console.WriteLine(string.Format("Расстояние от начала координат до конца отрезка = {0:0.00}", GetDistanceToEnd()));
        }

        public void Info(ConsoleColor fg, ConsoleColor bgc)
        {
            Console.ForegroundColor = fg;
            Console.BackgroundColor = bgc;
            Console.Clear();
            Info();
        }
    }
}
