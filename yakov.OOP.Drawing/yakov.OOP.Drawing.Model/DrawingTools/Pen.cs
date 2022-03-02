using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace yakov.OOP.Drawing.Model.DrawingTools
{
    [ToolTypeAttribute(ToolType.Pen)]
    public class Pen: Tool
    {
        public override ToolType ToolType { get; } = ToolType.Pen;
        public static Color Color { get; set; } = Color.FromRgb(0, 0, 0);
        public static int Width { get; set; } = 5;
    }
}
