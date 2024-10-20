using WinUI3Localizer;

namespace ETL.Contracts.Services;

public interface ILocalizationService
{
    Task InitializeAsync();

    IEnumerable<string> GetAvailableLanguages();

    string GetCurrentLanguage();

    Task SetLanguageAsync(string language);
}