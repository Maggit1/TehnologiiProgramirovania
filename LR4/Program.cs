using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_4
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"inputgen.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            //Чтение данных из файла и инициализация массива
            int N = Convert.ToInt32(Console.ReadLine());
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            double[] mas = new double[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToDouble(str_elem[i]);
            }

            //Вычисление максимального элемента массива
            double max = mas[0];
            for (int i = 0; i < N; i++)
            {
                if (max < mas[i])
                {
                    max = mas[i];
                }
            }
            
            //Вычисление среднего арифметического всех элементов
            double sum = 0, avr = 0;
            for (int i = 0; i < N; i++)
            {
                sum += mas[i];
            }
            avr = 1.0 * sum / N;

            //Массив, в котором элементы < avr, заменены на 0
            for (int i = 0; i < N; i++)
            {
                if (mas[i] < avr)
                {
                    mas[i] = 0;
                }
            }

            //Вывод максимального элемента массива
            Console.WriteLine(string.Format("{0:0.000000}", max));

            //Вывод среднего арифметического всех элементов
            Console.WriteLine(string.Format("{0:0.000000}", avr));

            //Вывод модифицированного массива
            for (int i = 0; i < N; i++)
            {
                Console.Write(mas[i] + " ");
            }


            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
