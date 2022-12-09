using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace JackXu.WPF.Task.ValueConverter
{
    public class HasPicture : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int id=(int)value;
            if (File.Exists($"/Task/Images/{id}.jpg"))
                return Visibility.Visible;
            else
                return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
          
        }
        
    }
   

    
}
