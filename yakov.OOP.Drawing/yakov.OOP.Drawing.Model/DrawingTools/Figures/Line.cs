using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace yakov.OOP.Drawing.Model.DrawingTools.Figures
{
    [ToolTypeAttribute(ToolType.Line)]
    public class Line : FigureBase
    {
        public override ToolType ToolType { get; } = ToolType.Line;
        public Line(Point mouseDownPos, Point mouseUpPos) : base(mouseDownPos, mouseUpPos)
        {
        }

        protected override void InitGraphObject(Point mouseDownPos, Point mouseUpPos)
        {
            var graphElement = new System.Windows.Shapes.Line();

            // Set graph parameters.
            graphElement.X1 = mouseDownPos.X;
            graphElement.Y1 = mouseDownPos.Y;
            graphElement.X2 = mouseUpPos.X;
            graphElement.Y2 = mouseUpPos.Y;

            Graph = graphElement;
        }
    }
}
