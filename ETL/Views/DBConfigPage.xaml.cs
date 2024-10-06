using ETL.ViewModels;
using ETL.Models;

namespace ETL.Views;

public sealed partial class DBConfigPage : Page
{
    public DBConfigViewModel ViewModel
    {
        get;
    }

    public DBConfigPage()
    {
        InitializeComponent();
        ViewModel = App.GetService<DBConfigViewModel>();
        DataContext = ViewModel;
        Loaded += OnPageLoaded;
    }

    private void OnPageLoaded(object sender, RoutedEventArgs e)
    {
        ViewModel.XamlRoot = this.XamlRoot;
        Debug.WriteLine($"XamlRoot 设置为: {ViewModel.XamlRoot}");
    }

    private void ListView_RightTapped(object sender, RightTappedRoutedEventArgs e)
    {
        if (sender is ListView listView)
        {
            var element = e.OriginalSource as FrameworkElement;
            if (element?.DataContext is ConnectionInfo connection)
            {
                listView.SelectedItem = connection;
            }
        }
    }
}
