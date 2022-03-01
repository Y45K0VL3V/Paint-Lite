using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using yakov.OOP.Drawing.Model.DrawingTools.Figures;
using yakov.OOP.Drawing.Model.DrawingTools;
using System.Reflection;

namespace yakov.OOP.Drawing.Model.GraphControls
{
    public static class FigureDrawingControl
    {
        public static void Draw(Canvas drawingField, Point leftTopPos, Point rightBottomPos, FigureBase figure)
        {
            SetFigurePos(leftTopPos, rightBottomPos, figure);
            drawingField.Children.Add(figure.Graph);
        }

        public static void Draw(Canvas drawingField, Point leftTopPos, Point rightBottomPos, ToolType toolType)
        {
            // If it's not a figure-tool type -> exit.
            if (toolType < ToolType.Line && toolType > ToolType.Circle)
                return;

            FigureBase figure = null;

            foreach (Type currType in typeof(FigureBase).Assembly.GetTypes())//.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                if (!currType.IsClass)
                    continue;

                if (toolType == (currType.GetCustomAttribute(typeof(ToolTypeAttribute)) as ToolTypeAttribute).ToolType)
                {
                    figure = currType.GetConstructor(new Type[] { currType }).Invoke(new Object[] { leftTopPos, rightBottomPos }) as FigureBase;
                    break;
                }
            }

            SetFigurePos(leftTopPos, rightBottomPos, figure);
        }

        // Set left top position for figure on canvas.
        private static void SetFigurePos(Point leftTopPos, Point rightBottomPos, FigureBase figure)
        {
            Canvas.SetLeft(figure.Graph, leftTopPos.X);
            Canvas.SetTop(figure.Graph, leftTopPos.Y);
        }
    }
}
