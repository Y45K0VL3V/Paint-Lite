using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakov.OOP.Drawing.Model.DrawingTools
{
    public enum ToolType
    {
        Pen,
        Brush,
        Line,
        Rect,
        RectRounded,
        Square,
        Ellipse,
        Circle,
        None = 999
    }
    public abstract class Tool
    {
        public abstract ToolType ToolType { get; }
    }
}
