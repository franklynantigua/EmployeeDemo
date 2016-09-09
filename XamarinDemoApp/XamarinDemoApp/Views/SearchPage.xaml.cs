
using Xamarin.Forms;
using XamarinDemoApp.ViewModels;

namespace XamarinDemoApp.Views
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage(MainViewModel mainViewModel)
        {
            InitializeComponent();

            BindingContext = mainViewModel;
        }
    }
}
