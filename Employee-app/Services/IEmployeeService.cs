using System;
using Employee_app.Models;

namespace Employee_app.Services
{
    public interface IEmployeeService
    {
        Task<bool> CreateEmployee(Employee employee);
        Task<List<Employee>> GetEmployeeList();
        Task<Employee> UpdateEmployee(Employee employee);
        Task<Employee> GetEmployee(int key);
        Task<bool> DeleteEmployee(int key);
    }
}

