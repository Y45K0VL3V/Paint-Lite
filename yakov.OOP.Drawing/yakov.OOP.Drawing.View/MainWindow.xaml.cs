using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using yakov.OOP.Drawing.ViewModel;

namespace yakov.OOP.Drawing.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainContext();
        }

        // Animate dropping color picker panel.
        private void OpenCloseColorPicker(double from, double to, object target)
        {
            var colorPickSize = new DoubleAnimation();
            try
            {
                colorPickSize.From = from;
                colorPickSize.To = to;
                colorPickSize.Duration = TimeSpan.FromSeconds(0.3);
            }
            catch
            {
                return;
            }

            // Non-exeption convert object to border and start animation if not null.
            (target as Border)?.BeginAnimation(WidthProperty, colorPickSize);
            (target as Border)?.BeginAnimation(HeightProperty, colorPickSize);
        }

        // Open full window to pick color.
        private void borderColorPick_MouseEnter(object sender, MouseEventArgs e)
        {
            OpenCloseColorPicker(borderColorPick.MinHeight, borderColorPick.MaxHeight, borderColorPick);
        }

        // Close full pick color window.
        private void borderColorPick_MouseLeave(object sender, MouseEventArgs e)
        {
            OpenCloseColorPicker(borderColorPick.Height, borderColorPick.MinHeight, borderColorPick);
        }
    }
}
