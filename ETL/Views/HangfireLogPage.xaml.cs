using ETL.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ETL.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class HangfireLogPage : Page
{
    public HangfireLogViewModel ViewModel
    {
        get;
    }

    public HangfireLogPage()
    {
        ViewModel = App.GetService<HangfireLogViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
