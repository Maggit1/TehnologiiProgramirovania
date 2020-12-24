using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_8
{
    class Видео: Мультимедиа
    {
        public Видео()
            :base()
        {
            Видеокодек = Видеокодеки.H265;
        }

        public Видео(int Width, int Height, Видеокодеки vCodec)
            :base(Width, Height)
        {
            Видеокодек = vCodec;
        }

        public Видеокодеки Видеокодек;

        public override string Соотношение
        {
            get
            {
                return base.Соотношение + "\n" + "Видеокодек: " + Видеокодек.ToString();
            }
        }

    }
}
