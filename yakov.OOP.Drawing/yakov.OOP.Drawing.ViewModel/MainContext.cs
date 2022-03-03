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
using yakov.OOP.Drawing.Model.GraphControls;

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
        private ToolType? _usingTool = ToolType.None;
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

        #region Tool parameters.
        public Color UsingColor
        {
            set
            {
                if (_usingTool == ToolType.None)
                    return;

                if (_usingTool == ToolType.Pen)
                {
                    PenColor = new SolidColorBrush(value);
                }
                else
                {
                    BrushColor = new SolidColorBrush(value);
                }
            }
        }

        public SolidColorBrush PenColor
        {
            get { return new SolidColorBrush(Model.DrawingTools.Pen.Color); }
            set 
            { 
                Model.DrawingTools.Pen.Color = value.Color;
                OnPropertyChanged("PenColor");
            }
        }

        public SolidColorBrush BrushColor
        {
            get { return new SolidColorBrush(Model.DrawingTools.Brush.Color); }
            set 
            { 
                Model.DrawingTools.Brush.Color = value.Color;
                OnPropertyChanged("BrushColor");
            }
        }

        public int WidthText
        {
            get { return Model.DrawingTools.Pen.Width; }
            set
            {
                Model.DrawingTools.Pen.Width = value;
            }
        }
        #endregion

        #region Detecting canvas activity
        private Point _leftTopPos;
        private Point _rightBottomPos;

        private bool _isLeftDown = false;

        private RelayCommand _leftButtonDown;
        public RelayCommand LeftButtonDown
        {
            get
            {
                // Invokes, when mouse left button down.
                return _leftButtonDown ?? (_leftButtonDown = new RelayCommand(obj =>
                {
                    _isLeftDown = true;
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
                    if (_isLeftDown)
                    {
                        _rightBottomPos = Mouse.GetPosition(_drawField);
                        DrawFigure();
                        _isLeftDown = false;
                    }
                }));
            }
        }

        private RelayCommand _leftButtonDrag;
        public RelayCommand LeftButtonDrag
        {
            get
            {
                // Invokes, when mouse move.
                return _leftButtonDrag ?? (_leftButtonDrag = new RelayCommand(obj =>
                {
                    if (!_isLeftDown)
                        return;

                    if (_usingTool <= ToolType.Brush)
                        StylusDrawingControl.Draw(_drawField, Mouse.GetPosition(_drawField), _usingTool);
                }));
            }
        }

        private RelayCommand _mouseCanvasEnter;
        public RelayCommand MouseCanvasEnter
        {
            get
            {
                // Invokes, when mouse move.
                return _mouseCanvasEnter ?? (_mouseCanvasEnter = new RelayCommand(obj =>
                {
                    if (Mouse.LeftButton == MouseButtonState.Released)
                    {
                        _isLeftDown = false;
                    }
                }));
            }
        }
        #endregion
        private void DrawFigure()
        {
            FigureDrawingControl.Draw(_drawField, _leftTopPos, _rightBottomPos, _usingTool);
        }

        // INotifyPropertyChanged realization.
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
