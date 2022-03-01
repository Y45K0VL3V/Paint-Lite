using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace yakov.OOP.Drawing.Model.DrawingTools
{
    public class Pen: Tool
    {
        public override ToolType Type { get; } = ToolType.Pen;
        public Color PenColor { get; set; }
        public int PenWidth { get; set; }
    }
}
