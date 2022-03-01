using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace yakov.OOP.Drawing.Model.DrawingTools.Figures
{
    public class Square : Rectangle
    {
        public override ToolType Type { get; } = ToolType.Square;
        public Square(Point mouseDownPos, Point mouseUpPos) : base(mouseDownPos, mouseUpPos)
        {
        }

        protected override void InitGraphObject(Point mouseDownPos, Point mouseUpPos)
        {
            var graphElement = new System.Windows.Shapes.Rectangle();

            // Square side = min(height, width).
            var height = Math.Abs(mouseDownPos.Y - mouseUpPos.Y);
            var width = Math.Abs(mouseDownPos.X - mouseUpPos.X);
            graphElement.Width = graphElement.Height = height > width ? width : height;

            Graph = graphElement;
        }
    }
}
