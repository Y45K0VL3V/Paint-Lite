using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace yakov.OOP.Drawing.Model.DrawingTools.Figures
{
    [ToolTypeAttribute(ToolType.RectRounded)]
    public class RoundedRectangle : Rectangle
    {
        public override ToolType ToolType { get; } = ToolType.RectRounded;
        public RoundedRectangle(Point mouseDownPos, Point mouseUpPos) : base(mouseDownPos, mouseUpPos)
        {
        }

        protected override void InitGraphObject(Point mouseDownPos, Point mouseUpPos)
        {
            var graphElement = new System.Windows.Shapes.Rectangle();

            graphElement.Width = Math.Abs(mouseDownPos.X - mouseUpPos.X);
            graphElement.Height = Math.Abs(mouseDownPos.Y - mouseUpPos.Y);

            graphElement.RadiusX = 15;
            graphElement.RadiusY = 15;

            Graph = graphElement;
        }
    }
}
