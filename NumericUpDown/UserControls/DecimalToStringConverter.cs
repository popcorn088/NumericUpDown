using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace NumericUpDown.UserControls
{
    public class DecimalToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                decimal dec = (decimal)value;
                return dec.ToString();
            }
            return "0";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                string str = (string)value;
                return decimal.Parse(str);
            }
            else
            {
                return 0.0m;
            }
        }
    }
}
