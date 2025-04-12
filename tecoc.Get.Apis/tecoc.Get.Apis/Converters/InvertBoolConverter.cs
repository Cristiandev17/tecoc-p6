

using System.Globalization;

namespace Tecoc.Get.Apis.Converters
{
    public class InvertBoolConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return value is bool booleanValue ? !booleanValue : null;
            //return !(bool?)value;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return null;
        }
    }
}