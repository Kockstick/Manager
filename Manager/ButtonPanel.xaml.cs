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
using System.Windows.Shapes;

namespace Manager
{
    /// <summary>
    /// Логика взаимодействия для ButtonPanel.xaml
    /// </summary>
    public partial class ButtonPanel : Canvas
    {
        public static readonly DependencyProperty BtnNameProperty = DependencyProperty.Register("BtnName", 
            typeof(string), typeof(ButtonPanel), new PropertyMetadata("Default"));

        public string BtnName
        {
            get
            {
                return (string)GetValue(BtnNameProperty);
            }
            set
            {
                SetValue(BtnNameProperty, value);
            }
        }

        public LeftPanel parent { get; set; }

        public ButtonPanel()
        {
            InitializeComponent();
        }

        private bool isAnim = true;

        private void Thumb_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!isAnim)
                return;

            Storyboard sb = (Storyboard)ButtonBorder.FindResource("ButtonEnterAnimation");
            sb.Begin();
        }

        private void Thumb_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!isAnim)
                return;

            Storyboard sb = (Storyboard)ButtonBorder.FindResource("ButtonLeavAnimation");
            sb.Begin();
        }

        private void Thumb_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!isAnim)
                return;
            isAnim = false;
            parent.pressedButton = this;
            Storyboard sb = (Storyboard)ButtonBorder.FindResource("ButtonClickAnimation");
            sb.Begin();
        }

        public void UnPress()
        {
            Storyboard sb = (Storyboard)ButtonBorder.FindResource("ButtonUnClickAnimation");
            sb.Begin();
            isAnim = true;
        }
    }
}
