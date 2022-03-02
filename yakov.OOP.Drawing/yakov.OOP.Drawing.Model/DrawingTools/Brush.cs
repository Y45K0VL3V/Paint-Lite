using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace yakov.OOP.Drawing.Model.DrawingTools
{
    [ToolTypeAttribute(ToolType.Brush)]
    public class Brush: Tool
    {
        public override ToolType ToolType { get; } = ToolType.Brush;
        public static Color Color { get; set; }
        public static int Width { get; set; }
    }
}
