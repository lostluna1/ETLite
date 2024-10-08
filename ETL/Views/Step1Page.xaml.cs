using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace ETL.Views
{
    public sealed partial class Step1Page : Page
    {
        public Step1Page()
        {
            this.InitializeComponent();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.Navigate(typeof(Step2Page));
                
            }
        }
    }
}
