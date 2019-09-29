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

namespace Nico_Claes_r0661818_2ITF1.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UCMain.Children.Add(new UserControlAccounts());
        }

        // uitklappen hoofdmenu
        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Visible;
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
        }

        // inklappen hoofdmenu
        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
            ButtonOpenMenu.Visibility = Visibility.Visible;
        }

        // open https://s4league.space in een webbrowser
        private void ButtonOpenSite_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://s4league.space");
        }

        // trigger knoppen hoofdmenu
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl usc = null;
            UCMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "ItemAccounts":
                    usc = new UserControlAccounts();
                    UCMain.Children.Add(usc);
                    break;
                case "ItemGUI":
                    usc = new UserControlGUI();
                    UCMain.Children.Add(usc);
                    break;
                case "ItemMaps":
                    usc = new UserControlMaps();
                    UCMain.Children.Add(usc);
                    break;
                case "ItemShop":
                    usc = new UserControlShop();
                    UCMain.Children.Add(usc);
                    break;
                default:
                    break;
            }
        }

        // verplaats venster
        private void dragArea_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        // sluit venster
        private void Button_Click(object sender, RoutedEventArgs e)
        {
             Application.Current.Shutdown();
        }
    }
}
