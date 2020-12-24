using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_8
{
    public enum Видеокодеки
    {
        H264,
        H265
    }

    public enum Палитра_Изображений
    {
        RGB,
        CMYK,
        Monochrome
    }

    public enum Растровые_Форматы
    {
        JPEG,
        PNG,
        BMP,
        GIF
    }

    public enum Векторные_Форматы
    {
        HPGL,
        DWG,
        DXF
    }

    class Program
    {
        static void Main(string[] args)
        {
            Мультимедиа[] mas = new Мультимедиа[5];

            mas[0] = new Мультимедиа(3, 2);

            mas[1] = new Видео(16, 9, Видеокодеки.H264);

            mas[2] = new Изображение(21, 9, Палитра_Изображений.RGB);

            mas[3] = new Растровое_Изображение(4, 3, Палитра_Изображений.Monochrome , Растровые_Форматы.PNG);

            mas[4] = new Векторное_Изображение(1, 1, Палитра_Изображений.CMYK, Векторные_Форматы.DXF);

            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(">>>>>>>>" + mas[i].GetType().Name);
                Console.WriteLine("Соотношение сторон: {0}", mas[i].Соотношение.ToString());
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
            


}   

