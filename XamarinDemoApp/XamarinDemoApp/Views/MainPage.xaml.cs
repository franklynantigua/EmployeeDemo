
using System;
using Xamarin.Forms;
using XamarinDemoApp.Models;
using XamarinDemoApp.ViewModels;

namespace XamarinDemoApp.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        { 
          InitializeComponent();           
        }

        private async  void  Button_OnClicked(object sender , EventArgs e)
        {
         await   Navigation.PushAsync(new NewEmployeePage());
        }

        
        private async void ListView_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var employee = EmployeesListView.SelectedItem as Employee;

            if (employee != null)
            {

              var  mainViewModel =  BindingContext as MainViewModel;
                if (mainViewModel !=null)
                {
                    mainViewModel.SelectedEmployee = employee;
                  await  Navigation.PushAsync(new NewEmployeePage(mainViewModel));
                }

            }
        }

        private async void SearchButton_OnClicked(object sender, EventArgs e)
        {
            var mainViewModel = BindingContext as MainViewModel;
            if (mainViewModel != null)
            {
                await    Navigation.PushAsync(new SearchPage(mainViewModel));

            }
        }
    }
}
