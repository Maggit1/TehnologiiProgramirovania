using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_8
{
    class Мультимедиа
    {
        public Мультимедиа(int Width, int Height)
        {
            Ширина = Width; Высота = Height; //Свойства, характерные только для затронутых типов файлов
        }

        public Мультимедиа()
        {
            Ширина = 16; Высота = 9;
        }

        public int Ширина, Высота;
        
        public virtual string Соотношение
        {
            get { return Ширина.ToString() + ":" + Высота.ToString(); }
        }       
    }
}
