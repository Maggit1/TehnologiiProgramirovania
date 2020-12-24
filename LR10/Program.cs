using System;
using MatrixLib;

namespace LW_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.Title = ("Лабораторная работа №10");

            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix();

            m1.GenerateMatrix(9, 3);
            m1.SaveMatrix("MX1.txt");
            
            m2.GenerateMatrix(6, 5);
            m2.SaveMatrix("MX2.txt");
                                                
            if (m1.LoadMatrix("MX1.txt"))
                m1.PrintMatrix();
            
            Console.WriteLine("\n\n");
            
            if (m2.LoadMatrix("MX2.txt"))
                m2.PrintMatrix();
            
            Console.WriteLine("\n\n");

            float sum;
            sum = m1.GetSumOfEven + m2.GetSumOfEven;
            
            Console.WriteLine
                ("Сумма элементов с чётной суммой индексов в двух матрицах = " 
                + sum.ToString("E3"));

            Console.ReadKey();
        }
    }
}
