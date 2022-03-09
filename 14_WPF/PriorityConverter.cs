using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace _14_WPF
{
    class PriorityConverter : IValueConverter
    {
        public object DependenyProperty { get; private set; }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((int)value) == 1)
            {
                return "Data/1.png";
            }
            return "Data/2.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
