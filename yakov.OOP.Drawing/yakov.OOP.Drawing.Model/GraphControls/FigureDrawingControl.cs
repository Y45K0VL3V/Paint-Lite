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
using System.Windows.Media;

namespace yakov.OOP.Drawing.Model.GraphControls
{
    public static class FigureDrawingControl
    {
        public static void Draw(Canvas drawingField, Point leftTopPos, Point rightBottomPos, FigureBase figure)
        {
            SetFigurePos(leftTopPos, rightBottomPos, figure);
            AddToCanvas(drawingField, figure);
        }

        public static void Draw(Canvas drawingField, Point leftTopPos, Point rightBottomPos, ToolType? toolType)
        {
            // If it's not a figure-tool type -> exit.
            if (toolType < ToolType.Line && toolType > ToolType.Circle)
                return;

            FigureBase figure = null;

            foreach (Type currType in typeof(FigureBase).Assembly.GetTypes())
            {
                if (!currType.IsClass)
                    continue;

                if (toolType == (currType.GetCustomAttribute(typeof(ToolTypeAttribute)) as ToolTypeAttribute)?.ToolType)
                {
                    var constructor = currType.GetConstructor(new Type[] { typeof(Point), typeof(Point) });
                    figure = constructor.Invoke(new Object[] { leftTopPos, rightBottomPos }) as FigureBase;
                    break;
                }
            }

            SetFigurePos(leftTopPos, rightBottomPos, figure);
            AddToCanvas(drawingField, figure);
        }

        // Set left top position for figure on canvas.
        private static void SetFigurePos(Point leftTopPos, Point rightBottomPos, FigureBase figure)
        {
            Canvas.SetLeft(figure.Graph, leftTopPos.X);
            Canvas.SetTop(figure.Graph, leftTopPos.Y);
        }

        private static void AddToCanvas(Canvas canvas, FigureBase figure)
        {
            figure.Graph.Fill = new SolidColorBrush(DrawingTools.Brush.Color);
            figure.Graph.Stroke = new SolidColorBrush(DrawingTools.Pen.Color);
            canvas.Children.Add(figure.Graph);
        }
    }
}
