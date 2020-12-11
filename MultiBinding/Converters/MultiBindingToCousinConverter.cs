using System;
using System.Globalization;
using System.Linq;
using Xamarin.Forms;

namespace MultiBinding.Converters
{
    public class MultiBindingToCousinConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values != null && targetType.IsAssignableFrom(typeof(string)) && parameter != null)
            {
                if (values.Contains(parameter))
                    return $"Hello Cousin {string.Join(" ", values)}";
                else 
                    return $"Hello {string.Join(" ", values)}";
            }

            return "Hello Stranger";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
