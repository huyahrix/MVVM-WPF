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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF___XAML___Material_Design
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class XAML_AnimationMenu : Window
    {
        public XAML_AnimationMenu()
        {
            InitializeComponent();
            btnClose.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnOpen_Click(object sender, RoutedEventArgs e)
        {
            btnClose.Visibility = Visibility.Visible;
            btnOpen.Visibility = Visibility.Hidden;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            btnClose.Visibility = Visibility.Hidden;
            btnOpen.Visibility = Visibility.Visible;
        }

    }
}
