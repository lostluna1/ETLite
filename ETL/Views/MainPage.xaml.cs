using ETL.Models;
using ETL.ViewModels;

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
        DataContext = ViewModel;
    }

    private void Breadcrumb_ItemClicked(BreadcrumbBar sender, BreadcrumbBarItemClickedEventArgs args)
    {
        var items = ViewModel.Folders;
        for (int i = items.Count - 1; i >= args.Index + 1; i--)
        {
            items.RemoveAt(i);
        }

        if (args.Index == 0)
        {
            ViewModel.NavigateToStep1Command.Execute(null);
        }
        else if (args.Index == 1)
        {
            ViewModel.NavigateToStep2Command.Execute(null);
        }
    }

    private void PreviousButton_Click(object sender, RoutedEventArgs e)
    {
        var items = Breadcrumb.ItemsSource as ObservableCollection<Folder>;
        if (items.Count > 1)
        {
            items.RemoveAt(items.Count - 1);
            if (items.Count == 1)
            {
                MainFrame.Navigate(typeof(Step1Page));
            }
        }

        UpdateButtonVisibility();
    }

    private void NextButton_Click(object sender, RoutedEventArgs e)
    {
        var items = Breadcrumb.ItemsSource as ObservableCollection<Folder>;
        if (items.Count == 1)
        {
            items.Add(new Folder { Name = "Step 2" });
            MainFrame.Navigate(typeof(Step2Page));
        }

        UpdateButtonVisibility();
    }

    private void UpdateButtonVisibility()
    {
        var items = Breadcrumb.ItemsSource as ObservableCollection<Folder>;
        PreviousButton.Visibility = items.Count > 1 ? Visibility.Visible : Visibility.Collapsed;
    }
}
