﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace yakov.OOP.Drawing.Model.DrawingTools.Figures
{
    public class Ellipse : FigureBase
    {
        public override ToolType Type { get; } = ToolType.Ellipse;
        public Ellipse(Point mouseDownPos, Point mouseUpPos) : base(mouseDownPos, mouseUpPos)
        {
        }
        
        protected override void InitGraphObject(Point mouseDownPos, Point mouseUpPos)
        {
            var graphElement = new System.Windows.Shapes.Ellipse();
            
            graphElement.Width = Math.Abs(mouseDownPos.X - mouseUpPos.X);
            graphElement.Height = Math.Abs(mouseDownPos.Y - mouseUpPos.Y);

            Graph = graphElement;
        }
    }
}
