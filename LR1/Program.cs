using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторня работа №1 «Разработка консольного приложения»");
            Console.WriteLine("");
            Console.WriteLine("=================================");
            Console.WriteLine("Кошевой Дмитрий Андреевич");
            Console.WriteLine("Группа: ИНС-б-о-19-1(1), 09.03.02");
            Console.WriteLine("Дата рождения: 4 июля 2001 года");
            Console.WriteLine("Город: Ставрополь");
            Console.WriteLine("=================================");
            Console.WriteLine("Любимый предмет в школе: Физика");
            Console.WriteLine("Увлечения, хобби, интересы: Собираю и настраиваю компьютеры. Чаще всего слушаю Queen и Guns N' Roses.");
            Console.WriteLine("");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("");
            
            Console.WriteLine("ВАРИАНТ 5");
            Console.WriteLine("");
                     
            Console.Write("Введите значение переменной g: ");
            double g = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной h: ");
            double h = Convert.ToDouble(Console.ReadLine());
            
            byte d = 2;
            Console.WriteLine("Значение d всегда будет равно 2");

            Console.Write("Введите значение переменной b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ненулевое значение переменной h1: ");
            double h1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение переменной y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            string str = "Задано:";
            Console.WriteLine(str);
            Console.WriteLine("g = {0}", g);
            Console.WriteLine("h = {0}", h);
            Console.WriteLine("d = {0}", d);
            Console.WriteLine("b = {0}", b);
            Console.WriteLine("h1 = {0}", h1);
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("y = {0}", y);
            Console.WriteLine("");
            Console.WriteLine("Решение и ответ:");
            Console.WriteLine("H = g*h/(d*17)+b/h1-(x+y)/4 = {0}*{1}/({2}*17)+{3}/{4}-({5}+{6})/4 = {7}", g, h, d, b, h1, x, y, g*h/(d*17)+b/h1-(x+y)/4);

            Console.WriteLine("");
            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////");
            Console.WriteLine("");
            Console.WriteLine("Для завершения работы программы нажмите на любую клавишу...");

            Console.ReadKey();
        }
    }
}
