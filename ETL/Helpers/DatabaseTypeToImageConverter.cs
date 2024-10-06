using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Media.Imaging;

namespace ETL.Converters;

public class DatabaseTypeToImageConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string databaseType)
        {
            return databaseType switch
            {
                "Oracle" => new BitmapImage(new Uri("ms-appx:///Assets/Oracle.png")),
                "SQL Server" => new BitmapImage(new Uri("ms-appx:///Assets/SQLserver.png")),
                "MySQL" => new BitmapImage(new Uri("ms-appx:///Assets/MySQL.png")),
                _ => new BitmapImage(new Uri("ms-appx:///Assets/StoreLogo.png")),
            };
        }
        return new BitmapImage(new Uri("ms-appx:///Assets/StoreLogo.png"));
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
