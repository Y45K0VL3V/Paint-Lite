using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace yakov.OOP.Drawing.Model.DrawingTools.Figures
{
    public class Rectangle : FigureBase
    {
        public Rectangle(Point mouseDownPos, Point mouseUpPos) : base(mouseDownPos, mouseUpPos)
        {
        }

        protected override void InitGraphObject(Point mouseDownPos, Point mouseUpPos)
        {
            var graphElement = new System.Windows.Shapes.Rectangle();

            graphElement.Width = Math.Abs(mouseDownPos.X - mouseUpPos.X);
            graphElement.Height = Math.Abs(mouseDownPos.Y - mouseUpPos.Y);

            Graph = graphElement;
        }
    }
}
