using Manuel_SoftwareDeveloperTest.Models;

namespace Manuel_SoftwareDeveloperTest.Repositories
{
    public interface IRepository
    {
        Employees GetEmployees();
        EmployeesById GetEmployeeById(int employeeId);
    }
}
