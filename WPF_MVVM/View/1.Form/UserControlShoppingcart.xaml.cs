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

namespace View._1.Form
{
    /// <summary>
    /// Interaction logic for UserControlMenu2.xaml
    /// </summary>
    public partial class UserControlShoppingCart : UserControl
    {
        public UserControlShoppingCart()
        {
            InitializeComponent();
        }
        private void LstView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = LstView.SelectedIndex;
            MoveCursorIndex(index);
            switch (index)
            {
                case 0:
                    {
                        var uriSource = new Uri("Assets/2.jpeg",UriKind.Relative);
                        mainImage.Source = new BitmapImage(uriSource);
                        break;
                    }
                case 1:
                    {
                        var uriSource = new Uri("Assets/12904418_p0.jpg", UriKind.Relative);
                        mainImage.Source = new BitmapImage(uriSource);
                        break;
                    }
                case 2:
                    {
                        var uriSource = new Uri("Assets/22885040_p0.jpg", UriKind.Relative);
                        mainImage.Source = new BitmapImage(uriSource);
                        break;
                    }
                case 3:
                    {
                        var uriSource = new Uri("Assets/Anime-2294416.jpeg", UriKind.Relative);
                        mainImage.Source = new BitmapImage(uriSource);
                        break;
                    }
                case 4:
                    {
                        var uriSource = new Uri("Assets/66027422_p0.jpg", UriKind.Relative);
                        mainImage.Source = new BitmapImage(uriSource);
                        break;
                    }
                default:
                    break;
            }
        }
        private void MoveCursorIndex(int index)
        {
            GridCursor.Margin = new Thickness(27, (58 + ((50) * index)), 0, 0);
        }
    }
}
