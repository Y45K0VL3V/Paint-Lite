using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using yakov.OOP.Drawing.Model;
using yakov.OOP.Drawing.Model.DrawingTools;
using yakov.OOP.Drawing.Model.DrawingTools.Figures;

namespace yakov.OOP.Drawing.ViewModel
{
    public class MainContext : INotifyPropertyChanged
    {
        public MainContext(Canvas drawField)
        {
            _drawField = drawField;
        }

        // Contain canvas, where all drawings appear.
        private Canvas _drawField;

        #region Tool choosing.
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
        #endregion

        public Color UsingColor { get; set; }

        #region Detecting canvas activity
        private Point _leftTopPos;
        private Point _rightBottomPos;

        private RelayCommand _leftButtonDown;
        public RelayCommand LeftButtonDown
        {
            get
            {
                // Invokes, when mouse left button down.
                return _leftButtonDown ?? (_leftButtonDown = new RelayCommand(obj =>
                {
                    _leftTopPos = Mouse.GetPosition(_drawField);
                }));
            }
        }

        private RelayCommand _leftButtonUp;
        public RelayCommand LeftButtonUp
        {
            get
            {
                // Invokes, when mouse left button up.
                return _leftButtonUp ?? (_leftButtonUp = new RelayCommand(obj =>
                {
                    _rightBottomPos = Mouse.GetPosition(_drawField);
                }));
            }
        }
        #endregion

        // INotifyPropertyChanged realisation.
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
