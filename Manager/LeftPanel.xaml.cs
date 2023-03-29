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
    public partial class LeftPanel : Canvas
    {
        private ButtonPanel _pressedButton;
        public ButtonPanel pressedButton
        {
            get
            {
                return _pressedButton;
            }
            set
            {
                if (_pressedButton != null)
                    _pressedButton.UnPress();
                    
                _pressedButton = value;
            }
        }
        public LeftPanel()
        {
            InitializeComponent();
            BtnPasswords.parent = this;
            BtnNotes.parent = this;
            BtnReminds.parent = this;
        }
    }
}
