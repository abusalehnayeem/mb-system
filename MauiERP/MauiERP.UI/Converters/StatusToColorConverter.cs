using System.Globalization;
using Microsoft.Maui.Graphics;

namespace MauiERP.UI.Converters
{
    public class StatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not string status)
                return Colors.Transparent;

            return status.ToLower() switch
            {
                "shipped" => Colors.Green,
                "pending" => Colors.Orange,
                "delivered" => Colors.Blue,
                _ => Colors.Gray,
            };
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
