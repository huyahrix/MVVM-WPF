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

namespace View._1.Form
{
    /// <summary>
    /// Interaction logic for NavigationDrawerPopUpMenu.xaml
    /// </summary>
    public partial class XAML_NavigationDrawerPopUpMenu : Window
    {
        public XAML_NavigationDrawerPopUpMenu()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            new XAML_MainMenu().Show();
            this.Close();
        }
    }
}
