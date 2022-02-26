using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using yakov.OOP.Drawing.Model.DrawingTools;

namespace yakov.OOP.Drawing.ViewModel
{
    public class MainContext : INotifyPropertyChanged
    {
        // Contain currently used drawing tool.
        private object _usingTool;
        public object UsingTool
        {
            get { return _usingTool; }  
            set 
            { 
                _usingTool = value;
                OnPropertyChanged("UsingTool");
            }
        }

        public Color UsingColor { get; set; }

        // INotifyPropertyChanged realisation.
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
