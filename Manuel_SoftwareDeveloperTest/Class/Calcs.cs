using Manuel_SoftwareDeveloperTest.Models;
using Manuel_SoftwareDeveloperTest.Repositories;
using System.Runtime.InteropServices;

namespace Manuel_SoftwareDeveloperTest.Class
{
    public class MiscClass
    {
        private EmployeesRepository employeeRepository;

        public MiscClass(EmployeesRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        /// <summary>
        /// Obtencion de los datos del trabajador por ID 
        /// </summary>
        /// <param name="id">Id del Trabajador que se quiere consultar</param>
        /// <returns>Datos del trabajador</returns>
        private EmployeesById getEmployeeById(int id)
        {
            return employeeRepository.GetEmployeeById(id);
        }

        /// <summary>
        /// Calculo del salario del empleado por periodo
        /// </summary>
        /// <param name="employeeId">Id del Empleado que se quiere calcular (Int)</param>
        /// <param name="period">Periodo que se desea calcular (3, 6, 9, 12) en trimestres acumulados (Default 12)</param>
        /// <returns>Valor del salario que se calcula acorde al periodo</returns>
        public int CalculatePeriodSalary(int employeeId, int period = 12)
        {
            EmployeesById employee = getEmployeeById(employeeId);
            int baseSalary = employee.data.employee_salary;
            int PeriodSalary = baseSalary * period;
            return PeriodSalary;
        }
    }
}
