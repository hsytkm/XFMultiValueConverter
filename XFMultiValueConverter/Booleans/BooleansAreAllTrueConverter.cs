using System;
using System.Globalization;
using Xamarin.Forms.Proxy;

namespace XFMultiValueConverter
{
    class BooleansAreAllTrueConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            foreach (var value in values)
            {
                if (!(value is bool b) || !b)
                    return false;
            }
            return true;
        }
    }
}
