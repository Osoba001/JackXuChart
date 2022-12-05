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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JackXu.WPF.Task.Views
{
    /// <summary>
    /// Interaction logic for TaskViews.xaml
    /// </summary>
    public partial class TaskViews : UserControl
    {
        public TaskViews()
        {
            InitializeComponent();
        }

        private void sidebar_selectedChanged(object sender, SelectionChangedEventArgs e)
        {
            var seletedPage = sidebar.SelectedItem as NavButton;
            navframe.Navigate(seletedPage!.NavUri);
        }
    }
}
