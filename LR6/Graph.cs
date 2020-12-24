using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_6
{
    class Graph
    {
        private double a, b;

        public double GetIntegral() { return ((b - a) * (b + a)) / 2; }

        public double GetLength() { return Math.Sqrt(Math.Pow((b - a), 2) + Math.Pow((b - a), 2)); }

        public void Info()
        {
            String str = "График y = x \n";

            Console.WriteLine(str);
            Console.WriteLine(string.Format("a = {0:0.00}", a));
            Console.WriteLine(string.Format("b = {0:0.00}", b));
            Console.WriteLine(string.Format("Интеграл = {0:0.00}", GetIntegral()));
            Console.WriteLine(string.Format("Длина отрезка функции = {0:0.00}", GetLength()));
        }

        public void Load()
        {
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
        }
    }
}
