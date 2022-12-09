using JackXu.WPF.Task.Models;
using JackXu.WPF.Task.ViewModels;
using Microsoft.Extensions.DependencyInjection;
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
    /// Interaction logic for CustomerInvoiceView.xaml
    /// </summary>
    public partial class CustomerInvoiceView : UserControl
    {
        private readonly IPayment payment;
  

        public CustomerInvoiceView()
        {
            InitializeComponent();
            
            payment = Payment.Instance;
            DataContext = App.ServiceProvider.GetRequiredService<CustomerInvoiceViewModel>();
            
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            txtBkSearch.Visibility = Visibility.Collapsed;
        }

        private void txtSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtSearch.Text.Trim() == string.Empty)
            {
                txtBkSearch.Visibility = Visibility.Visible;
            }
        }
    }
}
