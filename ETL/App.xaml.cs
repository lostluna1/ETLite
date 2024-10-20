using ETL.Activation;
using ETL.Contracts.Services;
using ETL.Core.Contracts.Services;
using ETL.Core.Services;
using ETL.Helpers;
using ETL.Models;
using ETL.Notifications;
using ETL.Services;
using ETL.ViewModels;
using ETL.Views;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Windows.Globalization;

namespace ETL;

// To learn more about WinUI 3, see https://docs.microsoft.com/windows/apps/winui/winui3/.
public partial class App : Application
{
    // The .NET Generic Host provides dependency injection, configuration, logging, and other services.
    // https://docs.microsoft.com/dotnet/core/extensions/generic-host
    // https://docs.microsoft.com/dotnet/core/extensions/dependency-injection
    // https://docs.microsoft.com/dotnet/core/extensions/configuration
    // https://docs.microsoft.com/dotnet/core/extensions/logging
    public IHost Host
    {
        get;
    }

    public static T GetService<T>()
        where T : class
    {
        if ((App.Current as App)!.Host.Services.GetService(typeof(T)) is not T service)
        {
            throw new ArgumentException($"{typeof(T)} needs to be registered in ConfigureServices within App.xaml.cs.");
        }

        return service;
    }

    public static WindowEx MainWindow { get; } = new MainWindow();

    public static UIElement? AppTitlebar
    {
        get; set;
    }

    private static bool isDialogOpen = false;

    public App()
    {
        InitializeComponent();
        Host = Microsoft.Extensions.Hosting.Host.
        CreateDefaultBuilder().
        UseContentRoot(AppContext.BaseDirectory).
        ConfigureServices((context, services) =>
        {
            // Default Activation Handler
            services.AddTransient<ActivationHandler<LaunchActivatedEventArgs>, DefaultActivationHandler>();

            // Other Activation Handlers
            services.AddTransient<IActivationHandler, AppNotificationActivationHandler>();

            // Services
            services.AddTransient<IWebViewService, WebViewService>();
            services.AddSingleton<IAppNotificationService, AppNotificationService>();
            services.AddSingleton<ILocalSettingsService, LocalSettingsService>();
            services.AddSingleton<IThemeSelectorService, ThemeSelectorService>();
            services.AddTransient<INavigationViewService, NavigationViewService>();
            services.AddSingleton<IHangfireJobService, HangfireJobService>();

            services.AddSingleton<IActivationService, ActivationService>();
            services.AddSingleton<IPageService, PageService>();
            services.AddSingleton<INavigationService, NavigationService>();
            services.AddSingleton<IDBConfigService, DBConfigService>();
            services.AddSingleton<ILocalizationService, LocalizationService>();

            // Core Services
            services.AddSingleton<ISampleDataService, SampleDataService>();
            services.AddSingleton<IFileService, FileService>();

            // Views and ViewModels
            services.AddTransient<HangFireResultsViewModel>();
            services.AddTransient<HangFireResultsPage>();
            services.AddTransient<HangfireLogViewModel>();
            services.AddTransient<HangfireLogPage>();
            services.AddTransient<Step2ViewModel>();
            services.AddTransient<Step2Page>();
            services.AddTransient<Step1ViewModel>();
            services.AddTransient<Step1Page>();
            services.AddTransient<DBConfigViewModel>();
            services.AddTransient<DBConfigPage>();
            services.AddTransient<SettingsViewModel>();
            services.AddTransient<SettingsPage>();
            services.AddTransient<MainViewModel>();
            services.AddTransient<MainPage>();
            services.AddTransient<ShellPage>();
            services.AddTransient<ShellViewModel>();

            services.AddHttpClient();
            // Configuration
            services.Configure<LocalSettingsOptions>(context.Configuration.GetSection(nameof(LocalSettingsOptions)));
        }).
        Build();
        // 从配置文件中读取语言设置
        //var configuration = Host.Services.GetRequiredService<IConfiguration>();
        //var language = configuration["AppSettings:Language"];
        //if (!string.IsNullOrEmpty(language))
        //{
        //    ApplicationLanguages.PrimaryLanguageOverride = language;
        //}
        App.GetService<IAppNotificationService>().Initialize();

        UnhandledException += App_UnhandledException;
    }

    private async void App_UnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
    {
        if (!isDialogOpen)
        {
            isDialogOpen = true;
            var dialog = new ContentDialog
            {
                Title = "未处理的异常",
                Content = $"异常来自: {e.Message}",
                CloseButtonText = "OK",
                XamlRoot = MainWindow.Content.XamlRoot
            };

            e.Handled = true;
            await dialog.ShowAsync();
            isDialogOpen = false;
        }
    }
    //public void ChangeLanguage(string languageCode)
    //{
    //    ApplicationLanguages.PrimaryLanguageOverride = languageCode;

    //    // 重新加载主窗口以应用语言更改
    //    MainWindow.Content = null;
    //    MainWindow.Content = new Frame();
    //    MainWindow.Content.Navigate(typeof(MainWindow));
    //}

    protected async override void OnLaunched(LaunchActivatedEventArgs args)
    {
        base.OnLaunched(args);
        //ApplicationLanguages.PrimaryLanguageOverride = ConfigurationManager.Instance.GetValue("AppSettings", "Language")??"zh-CN";

        //App.GetService<IAppNotificationService>().Show(string.Format("AppNotificationSamplePayload".GetLocalized(), AppContext.BaseDirectory));

        await App.GetService<IActivationService>().ActivateAsync(args);
        App.GetService<IAppNotificationService>().Show(string.Format("AppNotificationSamplePayload".GetLocalizedString(), AppContext.BaseDirectory));

    }
}
