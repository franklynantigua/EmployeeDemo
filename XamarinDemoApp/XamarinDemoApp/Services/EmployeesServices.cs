using Plugin.RestClient;
using System.Collections.Generic;
using System.Threading.Tasks;
using XamarinDemoApp.Models;

namespace XamarinDemoApp.Services
{
    public class EmployeesServices
    {
        public async  Task<List<Employee>> GetEmployeeAsync()
        {
            RestClient<Employee> restClient = new RestClient<Employee>();
            var employeesList = await restClient.GetAsync();

            return employeesList;
    }

        public async Task PostEmployeeAsync(Employee employee)
        {
            RestClient<Employee> restClient = new RestClient<Employee>();
            var employeesList = await restClient.PostAsync(employee);

            
        }

        public async Task PutEmployeeAsync(int id , Employee employee)
        {
            RestClient<Employee> restClient = new RestClient<Employee>();
            var employeesList = await restClient.PutAsync(id , employee);


        }

        public async Task DeleteEmployeeAsync(int id)
        {
            RestClient<Employee> restClient = new RestClient<Employee>();
            var employeesList = await restClient.DeleteAsync(id);


        }

        public async Task<List<Employee>> GetEmployeeBykeywordAsync(string keyword)
        {
            RestClient<Employee> restClient = new RestClient<Employee>();
            var employeesList = await restClient.GetByKeywordAsync(keyword);

            return employeesList;
        }
    }
}