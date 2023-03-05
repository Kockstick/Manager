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
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Manager
{
    /// <summary>
    /// Логика взаимодействия для ButtonPanel.xaml
    /// </summary>
    public partial class ButtonPanel : Canvas
    {
        public ButtonPanel()
        {
            InitializeComponent();
        }

        private void Thumb_MouseEnter(object sender, MouseEventArgs e) =>
            Mark(BgRect);

        private void Thumb_MouseLeave(object sender, MouseEventArgs e) =>
            UnMark(BgRect);

        private void Mark(Rectangle rect)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#252525");
            rect.Fill = new SolidColorBrush(color);
        }

        private void UnMark(Rectangle rect)
        {
            Color color = (Color)ColorConverter.ConvertFromString("#2B2B2B");
            rect.Fill = new SolidColorBrush(color);
        }
    }
}
