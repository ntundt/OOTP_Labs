using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTP_Lab5
{
    partial struct Color
    {
        public Color(byte red, byte green, byte blue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
        }
        public Color(EColor color)
        {
            this.Red = (byte)((((int)color) & 0xFF0000) >> 16);
            this.Green = (byte)((((int)color) & 0x00FF00) >> 8);
            this.Blue = (byte)(((int)color) & 0x0000FF);
        }
    }
}
