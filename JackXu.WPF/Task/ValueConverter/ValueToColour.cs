using JackXu.WPF.Task.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace JackXu.WPF.Task.ValueConverter
{
    public class ValueToColour : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Status status = (Status)value;
            switch (value)
            {
                case Status.Paid: return new SolidColorBrush(Colors.Green);
                case Status.Refunded: return new SolidColorBrush(Colors.Black); ;
                default:
                    return new SolidColorBrush(Colors.Red);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
