using CommunityToolkit.WinUI.UI.Controls;

using ETL.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace ETL.Views;

public sealed partial class HangFireResultsPage : Page
{
    public HangFireResultsViewModel ViewModel
    {
        get;
    }

    public HangFireResultsPage()
    {
        ViewModel = App.GetService<HangFireResultsViewModel>();
        InitializeComponent();
        DataContext = ViewModel;
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            //ViewModel.EnsureItemSelected();
        }
    }
}
