using ETL.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ETL.Views;

// To learn more about WebView2, see https://docs.microsoft.com/microsoft-edge/webview2/.
public sealed partial class WebContentPage : Page
{
    public WebContentViewModel ViewModel
    {
        get;
    }

    public WebContentPage()
    {
        ViewModel = App.GetService<WebContentViewModel>();
        InitializeComponent();

        ViewModel.WebViewService.Initialize(WebView);
    }
}
