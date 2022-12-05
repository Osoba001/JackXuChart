using JackXu.WPF.CustomControl;
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

namespace JackXu.WPF.Main.Views
{
    /// <summary>
    /// Interaction logic for StartupWindow.xaml
    /// </summary>
    public partial class StartupWindow : Window
    {
        public StartupWindow()
        {
            InitializeComponent();
            // homeNav =  new UriBuilder("/Main/Views/HomeView.xaml");
            //navframe.Navigate(homeNav);
        }

        private void sidebar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedPage = Menubar.SelectedItem as NavButton;
            navframe.Navigate(selectedPage!.NavUri);
        }

        private void bgWhite_Checked(object sender, RoutedEventArgs e)
        {
            this.Resources["myBackGround"] = new SolidColorBrush(Colors.White);
            this.Resources["sideBarBg"] = new SolidColorBrush(Colors.LightGray);
            this.Resources["fg"] = new SolidColorBrush(Colors.Black);
        }

        private void bgBlue_Checked(object sender, RoutedEventArgs e)
        {
            this.Resources["myBackGround"] = new SolidColorBrush(Colors.Blue);
            this.Resources["sideBarBg"] = new SolidColorBrush(Colors.DarkBlue);
            this.Resources["fg"] = new SolidColorBrush(Colors.White);
        }

        private void bgRed_Checked(object sender, RoutedEventArgs e)
        {
            this.Resources["myBackGround"] = new SolidColorBrush(Colors.Red);
            this.Resources["sideBarBg"] = new SolidColorBrush(Colors.DarkRed);
            this.Resources["fg"] = new SolidColorBrush(Colors.White);
        }

        private void bgBlack_Checked(object sender, RoutedEventArgs e)
        {
            this.Resources["myBackGround"] = new SolidColorBrush(Colors.Black);
            this.Resources["sideBarBg"] = new SolidColorBrush(Colors.DarkGray);
            this.Resources["fg"] = new SolidColorBrush(Colors.White);
            //this.Resources["fromResourceDictionary"] = Application.Current.FindResource("key");
        }
    }
}
