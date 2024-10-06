using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Navigation;
using ETL.ViewModels;
using ETL.Contracts.Services;

namespace ETL.Views;

public sealed partial class SettingsPage : Page
{
    public SettingsViewModel ViewModel
    {
        get;
    }

    public SettingsPage()
    {
        ViewModel = new SettingsViewModel(App.GetService<IThemeSelectorService>());
        InitializeComponent();
        DataContext = ViewModel;
    }

    private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.AddedItems.Count > 0)
        {
            var selectedComboBoxItem = e.AddedItems[0] as ComboBoxItem;
            if (selectedComboBoxItem != null)
            {
                ViewModel.SelectedLanguage = selectedComboBoxItem.Tag.ToString();
            }
        }
    }
}
