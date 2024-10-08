using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ETL.Contracts.Services;
using ETL.Contracts.ViewModels;
using ETL.Models;
using ETL.Services;
using ETL.Views;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Collections.ObjectModel;

namespace ETL.ViewModels;

public partial class MainViewModel : ObservableRecipient, INavigationAware
{
    [ObservableProperty]
    private ObservableCollection<Folder> _folders = new()
    {
        new Folder { Name = "Home" }
    };

    [ObservableProperty]
    private bool _isPreviousButtonVisible = false;

    private readonly INavigationService _navigationService;
    public MainViewModel(INavigationService navigationService)
    {
        _navigationService = navigationService;
        //NavigateToStep1();
    }
   

    public void OnNavigatedTo(object parameter)
    {
    }

    public void OnNavigatedFrom()
    {
    }
    [RelayCommand]
    private void NavigateToStep1()
    {
        _navigationService.NavigateTo(typeof(Step1ViewModel).FullName!);
        UpdateButtonVisibility();
    }

    [RelayCommand]
    private void NavigateToStep2()
    {
        _navigationService.NavigateTo(typeof(Step2ViewModel).FullName!);
        UpdateButtonVisibility();
    }

    [RelayCommand]
    private void Previous()
    {
        if (Folders.Count > 1)
        {
            Folders.RemoveAt(Folders.Count - 1);
            if (Folders.Count == 1)
            {
                NavigateToStep1();
            }
        }
    }

    [RelayCommand]
    private void Next()
    {
        if (Folders.Count == 1)
        {
            Folders.Add(new Folder { Name = "Step 2" });
            //NavigateToStep2();
        }
    }

    private void UpdateButtonVisibility()
    {
        IsPreviousButtonVisible = Folders.Count > 1;
    }
}
