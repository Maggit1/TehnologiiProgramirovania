using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LW_9
{
    public interface IGen
    {
        string Data { get; set; }
        void DrawContent();
    }
}