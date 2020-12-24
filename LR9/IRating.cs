using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_9
{
    public interface IRating
    {
        void Up(int pUp);
        void Down(int pDown);
    }
}