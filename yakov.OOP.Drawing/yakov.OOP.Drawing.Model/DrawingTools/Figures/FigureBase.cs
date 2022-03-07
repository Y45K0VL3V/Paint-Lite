using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace yakov.OOP.Drawing.Model.DrawingTools.Figures
{
    public abstract class FigureBase : Tool
    {
        public override ToolType ToolType { get; }

        protected FigureBase(Point mouseDownPos, Point mouseUpPos)
        {
            MouseLeftDownPos = mouseDownPos;
            MouseLeftUpPos = mouseUpPos;
            InitGraphObject(mouseDownPos, mouseUpPos);
        }

        public Point MouseLeftDownPos { get; set; }
        
        public Point MouseLeftUpPos { get; set; }

        // Contains graph view of figure.
        public Shape Graph { get; set; }

        // Creates graph view of figure.
        protected abstract void InitGraphObject(Point mouseDownPos, Point mouseUpPos);
    }
}
