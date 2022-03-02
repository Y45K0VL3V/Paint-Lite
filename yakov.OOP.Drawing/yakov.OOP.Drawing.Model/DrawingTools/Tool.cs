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
        Circle
    }
    public abstract class Tool
    {
        public virtual ToolType ToolType { get; }
    }
}
