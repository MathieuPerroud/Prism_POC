using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Prism_POC.Core.Utils.Converters
{
    public class UnknownCostConverter : IValueConverter
    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((string)value == "unknown")
            {
                return Color.FromHex("#FF3333");
            }
            else
            {
                return Color.FromHex("#333333");
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((Color)value == Color.FromHex("#FF3333"))
            {
                return "unknown";
            }
            else
            {
                return "";
            }
        }
    }
}
