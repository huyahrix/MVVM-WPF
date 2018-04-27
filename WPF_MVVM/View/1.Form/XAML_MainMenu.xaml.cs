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
using ViewModel.Module;

namespace View._1.Form
{
    /// <summary>
    /// Interaction logic for XAML_Menu2.xaml
    /// </summary>
    public partial class XAML_MainMenu : Window
    {
        public XAML_MainMenu()
        {
            InitializeComponent();
            GridPrincipal.Children.Clear();
            GridPrincipal.Children.Add(new UserControlShoppingCart());
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);
            switch (index)
            {
                case 0:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControlShoppingCart());
                    break;
                case 1:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControlMenu_Food());
                    break;
                case 2:
                    {
                        new XAML_NavigationDrawerPopUpMenu().Show();
                        this.Close();
                        break;
                    }
                case 5:
                    GridPrincipal.Children.Clear();
                    GridPrincipal.Children.Add(new UserControlIntro());
                    break;
                case 6:
                    new XAML_People().Show();
                    this.Close();
                    break;
                default:
                    break;
            }
        }

        private void MoveCursorMenu(int index)
        {
            //  TransitionContentSlide.OnApplyTemplate ();
            GridCursor.Margin = new Thickness(0, (62 + (50 * index)), 0, 0);

        }
        private void Menu_Click(object sender, RoutedEventArgs e)
        {
            XAML_TabMenu tabmenu = new XAML_TabMenu();
            this.Close();
            tabmenu.Show();
        }


    }
}
