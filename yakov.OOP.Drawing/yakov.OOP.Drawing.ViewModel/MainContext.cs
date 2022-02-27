using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;
using yakov.OOP.Drawing.Model;
using yakov.OOP.Drawing.Model.DrawingTools;
using yakov.OOP.Drawing.Model.DrawingTools.Figures;

namespace yakov.OOP.Drawing.ViewModel
{
    public enum ToolType
    {
        Pen,
        Line,
        Rect,
        RectRounded,
        Square,
        Ellipse,
        Circle
    }
    public class MainContext : INotifyPropertyChanged
    {
        // Get tool type by index.
        // Index - selected item in view.
        private ToolType? GetToolByIndex(int? index)
        {
            if (index == null) return null;

            for (ToolType toolType = ToolType.Pen; toolType <= ToolType.Circle; toolType++)
            {
                if ((int)toolType == index)
                {
                    return toolType;
                }
            }

            return null;
        }

        // Contain currently used drawing tool.
        private ToolType? _usingTool;
        public int? UsingTool
        {
            get 
            { 
                if (_usingTool != null) 
                    return (int)_usingTool; 
                else 
                    return null; 
            }  
            set 
            { 
                _usingTool = GetToolByIndex(value);
                OnPropertyChanged("UsingTool");
            }
        }

        public Color UsingColor { get; set; }

        private RelayCommand com;
        public RelayCommand Com
        {
            get
            {
                return com ?? (com = new RelayCommand(obj =>
                {
                    
                }));
            }
        }

        // INotifyPropertyChanged realisation.
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
