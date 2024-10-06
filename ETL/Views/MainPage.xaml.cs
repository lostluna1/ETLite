using ETL.Helpers;
using ETL.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ETL.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        Debug.WriteLine(ConnectionManager.Instance.CurrentConnection?.ServerAddress);
    }
}
