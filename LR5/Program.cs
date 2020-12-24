using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_5
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"matrix.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            //Чтение данных из файла и инициализация массива
            //и вывод исходной матрицы
            int M = Convert.ToInt32(Console.ReadLine());
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*** Input matrix ***");
            int[,] mass = new int[M, N];
            for (int i = 0; i < M; i++)
            {
                string str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mass[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            //Среднее арифметическое чётных элементов для каждого столбца 
            double avr = 0;
            double[] even = new double[N];
            Console.WriteLine("*** Average for even ***");
            for (int j = 0, k = 0; j < N; j++)
            {
                for (int i = 0; i < M; i++)
                {
                    if (mass[i, j] % 2 == 0)
                    {
                        avr += mass[i, j];
                    }
                }
                even[k] = avr / M;
                Console.WriteLine("Среднее арифметическое столбца " + (j + 1) + " равно: " + even[k]);
                k++;
            }

            //Вывод модифицированной матрицы 
            Console.WriteLine("*** Modified matrix ***");
            for (int i = 0; i < M; i++)
            {
                for (int j = 0, k = 0; j < N; j++)
                {
                    if (mass[i, j] < even[k])
                        Console.Write("q ");
                    else
                        Console.Write("z ");
                }
                Console.WriteLine();
            }


            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}
