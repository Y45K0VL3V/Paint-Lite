using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace yakov.OOP.Drawing.Model.DrawingTools.Figures
{
    [ToolTypeAttribute(ToolType.Circle)]
    public class Circle : Ellipse
    {
        public override ToolType ToolType { get; } = ToolType.Circle;
        public Circle(Point mouseDownPos, Point mouseUpPos) : base(mouseDownPos, mouseUpPos)
        {
        }

        protected override void InitGraphObject(Point mouseDownPos, Point mouseUpPos)
        {
            var graphElement = new System.Windows.Shapes.Ellipse();

            // Circle radius = min(height, width).
            var height = Math.Abs(mouseDownPos.Y - mouseUpPos.Y);
            var width = Math.Abs(mouseDownPos.X - mouseUpPos.X);
            graphElement.Width = graphElement.Height = height > width ? width : height;

            Graph = graphElement;
        }
    }
}
