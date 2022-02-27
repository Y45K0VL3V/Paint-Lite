using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace yakov.OOP.Drawing.Model.DrawingTools.Figures
{
    abstract public class FigureBase
    {
        public FigureBase(Point mouseDownPos, Point mouseUpPos)
        {
            MouseLeftDownPos = mouseDownPos;
            MouseLeftUpPos = mouseUpPos;
        }

        public Point MouseLeftDownPos { get; set; }
        
        public Point MouseLeftUpPos { get; set; }

        public Shape Graph { get; set; }

        protected virtual void InitGraphObject(Point mouseDownPos, Point mouseUpPos)
        {
        }
    }
}
