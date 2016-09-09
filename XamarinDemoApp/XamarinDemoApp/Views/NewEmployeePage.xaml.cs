
using Xamarin.Forms;
using XamarinDemoApp.ViewModels;

namespace XamarinDemoApp.Views
{
    public partial class NewEmployeePage : ContentPage
    {
        public NewEmployeePage()
        {
            InitializeComponent();
        }
        public NewEmployeePage(MainViewModel mainViewModel)
        {
            InitializeComponent();

            BindingContext = mainViewModel;
        }

    }
}
