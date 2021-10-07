using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOTP_Lab5
{
    interface Decorated
    {
        Color BackgroundColor { get; set; }
        Color BorderColor { get; set; }
        Color TextColor { get; set; }
        float TextSize { get; set; }
    }
}
