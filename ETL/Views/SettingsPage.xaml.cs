using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using ETL.ViewModels;
using ETL.Contracts.Services;
using Microsoft.Extensions.Configuration;
using ETL.Models;

namespace ETL.Views;

public sealed partial class SettingsPage : Page
{
    public SettingsViewModel ViewModel
    {
        get;
    }
    public IConfiguration configuration
    {
        get;
    }
    public SettingsPage()
    {
        // 使用依赖注入获取IConfiguration实例
        //var configuration = App.GetService<IConfiguration>();
        //ViewModel = new SettingsViewModel(App.GetService<IThemeSelectorService>());
        ViewModel = App.GetService<SettingsViewModel>();

        InitializeComponent();
        DataContext = ViewModel;
    }

    /*private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.AddedItems.Count > 0)
        {
            var selectedLanguageOption = e.AddedItems[0] as LanguageOption;
            if (selectedLanguageOption != null)
            {
                ViewModel.SelectedLanguage = selectedLanguageOption.Tag;
            }
        }
    }*/
    //private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    //{
    //    if (e.AddedItems.Count > 0)
    //    {
    //        var selectedLanguageOption = e.AddedItems[0] as LanguageOption;
    //        if (selectedLanguageOption != null)
    //        {
    //            ViewModel.SelectedLanguage = selectedLanguageOption;
    //        }
    //    }
    //}

}
