using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eilink_webapp.Data
{
    interface IEmployeeService
    {
        Task<List<eilink_webapp.Data.Employee>> GetEmployees();
        Task<bool> CreateEmployee(eilink_webapp.Data.Employee employee);
        Task<bool> EditEmployee(string id, eilink_webapp.Data.Employee employee);
        Task<eilink_webapp.Data.Employee> SingleEmployee(string id);
        Task<bool> DeleteEmployee(string id);
    }
}
