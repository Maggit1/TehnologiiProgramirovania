using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_9
{
    public class Video : IRating, IGen
    {
        public Video(string pAuthor, string pTitle, int pViews)
        {
            Author = pAuthor;
            Title = pTitle;
            Views = pViews;
        }

        private string Author;
        private string Title;
        private int Views;

        public void Up(int pUp)
        {
            Views += pUp;
        }

        public void Down(int pDown)
        {
            Views -= pDown;
        }

        public string Data
        {
            get
            {
                return
                    "Автор видео: " + Author + "\n" +
                    "Название видео: " + Title + "\n" +
                    "Просмотры видео: " + Views.ToString() + " million";
            }
            set
            {
                Author = value;
            }
        }

        public void DrawContent()
        {
            Console.WriteLine
                (
                    "\n" +
                    "|||||||||||||||||||||||\n" +
                    "||||||||=QUEEN=||||||||\n" +
                    "|||||||||||||||||||||||\n" +
                    "|||||||_LIVE AT_|||||||\n" +
                    "|||_WEMBLEY STADIUM_|||\n" +
                    "||||||||-1986-|||||||||\n" +
                    "|||||||||||||||||||||||\n"
                );
            Console.WriteLine(Data);
        }
    }
}