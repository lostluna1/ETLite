using Microsoft.Windows.ApplicationModel.Resources;

namespace ETL.Helpers;

public static class ResourceExtensions
{
    private static readonly ResourceLoader _resourceLoader = new();
    public static string GetLocalizedString(this string resourceKey) => WinUI3Localizer.Localizer.Get().GetLocalizedString(resourceKey);

    public static string GetLocalized(this string resourceKey) => _resourceLoader.GetString(resourceKey);
}
