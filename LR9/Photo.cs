using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_9
{
    public class Photo : IRating, IGen
    {
        public Photo(string pCamerist, string pLocation, int pLikes)
        {
            Camerist = pCamerist;
            Location = pLocation;
            Likes = pLikes;
        }

        private string Camerist;
        private string Location;
        private int Likes;

        public void Up(int pUp)
        {
            Likes += pUp;
        }

        public void Down(int pDown)
        {
            Likes -= pDown;
        }

        public string Data
        {
            get
            {
                return
                    "Фотограф: " + Camerist + "\n" +
                    "Местонахождение: " + Location + "\n" +
                    "Лайки фото: " + Likes.ToString() + " thousand";
            }
            set
            {
                Camerist = value;
            }
        }

        public void DrawContent()
        {
            Console.WriteLine
                (
                    "|||||||||||||||||||||||\n" +
                    "|||||***USE YOUR***||||\n" +
                    "|||||***ILLUSION***||||\n" +
                    "|||||*AND U'LL SEE*||||\n" +
                    "|||||||||||||||||||||||\n"
                );
            Console.WriteLine(Data);
        }
    }
}