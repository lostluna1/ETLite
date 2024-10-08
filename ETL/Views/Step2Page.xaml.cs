using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

namespace ETL.Views
{
    public sealed partial class Step2Page : Page
    {
        public Step2Page()
        {
            this.InitializeComponent();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.Frame != null)
            {
                this.Frame.GoBack();
                //((MainPage)((Frame)Parent).Parent).UpdateBreadcrumb("Step 1");
            }
        }
    }
}
