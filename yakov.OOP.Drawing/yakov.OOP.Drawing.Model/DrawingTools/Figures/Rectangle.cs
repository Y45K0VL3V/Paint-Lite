using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace yakov.OOP.Drawing.Model.DrawingTools.Figures
{
    [ToolTypeAttribute(ToolType.Rect)]
    public class Rectangle : FigureBase
    {
        public override ToolType ToolType { get; } = ToolType.Rect;
        public Rectangle(Point mouseDownPos, Point mouseUpPos) : base(mouseDownPos, mouseUpPos)
        {
        }

        protected override void InitGraphObject(Point mouseDownPos, Point mouseUpPos)
        {
            var graphElement = new System.Windows.Shapes.Rectangle();

            // Set graph parameters.
            graphElement.Width = Math.Abs(mouseDownPos.X - mouseUpPos.X);
            graphElement.Height = Math.Abs(mouseDownPos.Y - mouseUpPos.Y);

            Graph = graphElement;
        }
    }
}
