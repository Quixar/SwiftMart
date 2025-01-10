using SwiftMart.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// User control for displaying an overview of the user's session, including their full name.
/// </summary>
namespace SwiftMart
{
    /// <summary>
    /// Логика взаимодействия для OverviewControl.xaml
    /// </summary>
    public partial class OverviewControl : UserControl
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="OverviewControl"/> class.
        /// Displays the user's full name from the session in the corresponding text element.
        /// </summary>
        public OverviewControl()
        {
            InitializeComponent();
            UserSessionName.Text = CustomerSession.Instance.Name + " " + CustomerSession.Instance.Lastname;

        }
    }
}
