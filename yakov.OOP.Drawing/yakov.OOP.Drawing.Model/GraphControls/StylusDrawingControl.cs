using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using yakov.OOP.Drawing.Model.DrawingTools;

namespace yakov.OOP.Drawing.Model.GraphControls
{
    public class StylusDrawingControl
    {
        public static void Draw(Canvas drawingField, Point pos, ToolType? toolType)
        {
            var dot = new System.Windows.Shapes.Ellipse();
            dot.Height = dot.Width = DrawingTools.Pen.Width;

            // Go through types in this assembly.
            foreach (Type currType in typeof(Tool).Assembly.GetTypes())
            {
                // Searching only classes.
                if (!currType.IsClass)
                    continue;

                // Check, if selected tool type equal to tool type meta data of current class.
                if (toolType == (currType.GetCustomAttribute(typeof(ToolTypeAttribute)) as ToolTypeAttribute)?.ToolType)
                {
                    try
                    {
                        dot.Fill = new SolidColorBrush((Color)currType.GetProperty("Color")?.GetValue(null));
                        break;
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            SetDotPos(pos, dot);
            drawingField.Children.Add(dot);
        }

        // Set left top position for figure on canvas.
        private static void SetDotPos(Point pos, System.Windows.Shapes.Ellipse dot)
        {
            Canvas.SetLeft(dot, pos.X);
            Canvas.SetTop(dot, pos.Y);
        }
    }
}
