using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_8
{
    class Изображение: Мультимедиа
    {
        public Изображение(int Width, int Height, Палитра_Изображений ImgColor)
            :base(Width, Height)
        {
            Палитра_Изображения = ImgColor;
        }

        public Палитра_Изображений Палитра_Изображения;

        public override string Соотношение
        {
            get
            {
                return base.Соотношение + "\n" + "Цветовая палитра: " + Палитра_Изображения.ToString();
            }
        }
    }
}
