using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_8
{
    class Растровое_Изображение : Изображение
    {
        public Растровое_Изображение(int Width, int Height, Палитра_Изображений ImgColor, Растровые_Форматы rFormat)
            : base(Width, Height, ImgColor)
        {
            Растровый_Формат = rFormat;
        }

        public Растровые_Форматы Растровый_Формат;

        public override string Соотношение
        {
            get
            {
                return base.Соотношение + "\n" + "Формат: " + Растровый_Формат.ToString();
            }
        }
    }
}

