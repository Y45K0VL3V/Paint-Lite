using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yakov.OOP.Drawing.Model.DrawingTools
{
    public class ToolTypeAttribute : System.Attribute
    {
        public ToolTypeAttribute(ToolType toolType)
        {
            ToolType = toolType;
        }

        public ToolType ToolType { get; }
    }
}
