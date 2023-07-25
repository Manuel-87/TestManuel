using Manuel_SoftwareDeveloperTest.Class;
using Manuel_SoftwareDeveloperTest.Models;
using Manuel_SoftwareDeveloperTest.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Manuel_SoftwareDeveloperTest.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IRepository _repository;

        public EmployeesController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            var employees = new Employees();
            employees = _repository.GetEmployees();
            return View("Employees/Index", employees);
        }

        [HttpPost]
        public ActionResult Search(int employeeId)
        {
            var employee = _repository.GetEmployeeById(employeeId);
            return View("Employees/EmployeeDetails", employee);
        }

        [HttpPost]
        [HttpPost]
        public ActionResult CalculateSalary(int employeeId, int period)
        {
            var employee = _repository.GetEmployeeById(employeeId);

            if (employee.data != null)
            {
                var miscClass = new MiscClass(new EmployeesRepository()); // Aquí se utiliza el nuevo constructor
                int periodSalary = miscClass.CalculatePeriodSalary(employeeId, period);

                ViewBag.PeriodSalary = periodSalary;
            }

            return View("Employees/EmployeeDetails", employee);
        }

    }
}
