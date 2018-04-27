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
    /// Interaction logic for XAML_TabMenu.xaml
    /// </summary>
    public partial class XAML_TabMenu : Window
    {
        public XAML_TabMenu()
        {
            InitializeComponent();
            str.Background = new SolidColorBrush(Colors.LightPink);
        }

        private void btnPower_Click(object sender, RoutedEventArgs e)
        {
          
            XAML_MainMenu menu2 = new XAML_MainMenu();
            menu2.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            int index = int.Parse(((Button)e.Source).Uid);
            GridCursor.Margin = new Thickness (10+(150*index),0,0,0);
            switch(index)
            {
                case 0:
                    str.Background = new SolidColorBrush(Colors.PaleTurquoise) ;
                    break;
                case 1:
                    str.Background = new SolidColorBrush(Colors.Cornsilk);
                    break;
                case 2:
                    str.Background = new SolidColorBrush(Colors.Khaki);
                    break;
                case 3:
                    str.Background = new SolidColorBrush(Colors.DarkSlateBlue);
                    break;
                case 4:
                    str.Background = new SolidColorBrush(Colors.OliveDrab);
                    break;
                case 5:
                    str.Background = new SolidColorBrush(Colors.LightPink);
                    break;
                case 6:
                    str.Background = new SolidColorBrush(Colors.RosyBrown);
                    break;
            }       
        }
    }
}
