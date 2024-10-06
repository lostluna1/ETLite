using System.Globalization;
using System.Reflection;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ETL.Contracts.Services;
using ETL.Contracts.ViewModels;
using ETL.Helpers;
using ETL.Views;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.ApplicationModel;
using Windows.Globalization;
using static ETL.Views.ShellPage;
namespace ETL.ViewModels;

public partial class SettingsViewModel : ObservableRecipient, INavigationAware
{
    private readonly IThemeSelectorService _themeSelectorService;

    [ObservableProperty]
    private ElementTheme _elementTheme;

    [ObservableProperty]
    private string _versionDescription;

    [ObservableProperty]
    private string _selectedLanguage;

    public ICommand SwitchThemeCommand
    {
        get;
    }
    public void OnNavigatedTo(object parameter)
    {
    
    }

    public void OnNavigatedFrom()
    {
    
    }
    public SettingsViewModel(IThemeSelectorService themeSelectorService)
    {
        _themeSelectorService = themeSelectorService;
        _elementTheme = _themeSelectorService.Theme;
        _versionDescription = GetVersionDescription();
        _selectedLanguage = ApplicationLanguages.PrimaryLanguageOverride;

        SwitchThemeCommand = new RelayCommand<ElementTheme>(
            async (param) =>
            {
                if (ElementTheme != param)
                {
                    ElementTheme = param;
                    await _themeSelectorService.SetThemeAsync(param);
                }
            });
    }

    private static string GetVersionDescription()
    {
        Version version;

        if (RuntimeHelper.IsMSIX)
        {
            var packageVersion = Package.Current.Id.Version;
            version = new(packageVersion.Major, packageVersion.Minor, packageVersion.Build, packageVersion.Revision);
        }
        else
        {
            version = Assembly.GetExecutingAssembly().GetName().Version!;
        }

        return $"{"AppDisplayName".GetLocalized()} - {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";
    }

    partial void OnSelectedLanguageChanged(string value)
    {
        if (!string.IsNullOrEmpty(value))
        {
            ApplicationLanguages.PrimaryLanguageOverride = value;
            //MainWindow mainWindow = new MainWindow();
            //mainWindow.Activate();
            //NavigationFrame.Navigate(typeof(SettingsPage));
        }
    }


}
