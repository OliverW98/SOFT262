using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Xamarin.Forms;

namespace ColorConverter
{
    class ColorConverter : IValueConverter
    {

        //Implement this method to convert value to targetType by using parameter and culture.
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int v = (int)value;
            Color c;
            switch (v)
            {
                case 0:
                    c = Color.Red;
                    break;
                case 1:
                    c = Color.Gold;
                    break;
                case 2:
                    c = Color.Green;
                    break;
                default:
                    c = Color.Black;
                    break;
            }
            return c;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
