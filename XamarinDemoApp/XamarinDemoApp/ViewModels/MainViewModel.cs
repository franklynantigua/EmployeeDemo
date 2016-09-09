using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinDemoApp.Models;
using XamarinDemoApp.Services;

namespace XamarinDemoApp.ViewModels
{
    public  class MainViewModel : INotifyPropertyChanged
    {

        private  List<Employee> _employeesList;
        private Employee _selectedEmployee = new Employee();
        private List<Employee> _searchedEmployees;
        private string _keyword;

        public string Keyword
        {
            get { return _keyword; }
            set
            {
                _keyword = value;
                OnPropertyChanged();
            }
        }

        public List<Employee> EmployeesList
        {
            get{ return _employeesList; }
            set
            { _employeesList = value;
                OnPropertyChanged();
            }
        }

        public List<Employee> SearchedEmployees
        {
            get { return _searchedEmployees; }
            set
            {
                _searchedEmployees = value;
                OnPropertyChanged();
            }
        }

        public Employee SelectedEmployee
        {
            get { return _selectedEmployee; }
            set
            {
                _selectedEmployee = value;
                OnPropertyChanged();
            }
        }


        public Command PostCommand
        {
            get {
                return new Command(async() =>
                {

                    var employeesServices = new EmployeesServices();
                  await  employeesServices.PostEmployeeAsync(_selectedEmployee);
                });
                
                }
        }


        public Command PutCommand
        {
            get
            {
                return new Command(async () =>
                {

                    var employeesServices = new EmployeesServices();
                    await employeesServices.PutEmployeeAsync(_selectedEmployee.Id, _selectedEmployee);
                });

            }
        }

        public Command SearchCommand
        {
            get
            {
                return new Command(async () =>
                {

                    var employeesServices = new EmployeesServices();
                  SearchedEmployees =   await employeesServices.GetEmployeeBykeywordAsync(_keyword);
                });

            }
        }

        public Command DeleteCommand
        {
            get
            {
                return new Command(async () =>
                {

                    var employeesServices = new EmployeesServices();
                   await employeesServices.DeleteEmployeeAsync(_selectedEmployee.Id);
                });

            }
        }

        public MainViewModel()
        {
            InitializeDataAsync();

        }

        private async Task InitializeDataAsync()
        {
            var employeesServices = new EmployeesServices();

            EmployeesList = await employeesServices.GetEmployeeAsync();

        }

        public event PropertyChangedEventHandler PropertyChanged;


        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
