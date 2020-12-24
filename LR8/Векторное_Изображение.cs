using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_8
{
    class Векторное_Изображение: Изображение
    {
        public Векторное_Изображение(int Width, int Height, Палитра_Изображений ImgColor, Векторные_Форматы vFormat)
            : base(Width, Height, ImgColor)
        {
            Векторный_Формат = vFormat;
        }

        public Векторные_Форматы Векторный_Формат;

        public override string Соотношение
        {
            get
            {
                return base.Соотношение + "\n" + "Формат: " + Векторный_Формат.ToString();
            }
        }
    }
}
