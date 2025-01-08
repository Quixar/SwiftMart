using SwiftMart.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для OverviewControl.xaml
    /// </summary>
    public partial class OverviewControl : UserControl
    {
        public OverviewControl()
        {
            InitializeComponent();
            UserSessionName.Text = CustomerSession.Instance.Name + " " + CustomerSession.Instance.Lastname;
        }
    }
}
