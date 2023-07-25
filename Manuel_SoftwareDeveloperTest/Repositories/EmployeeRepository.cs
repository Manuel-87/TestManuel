using Manuel_SoftwareDeveloperTest.Models;
using Manuel_SoftwareDeveloperTest.Repositories;
using Newtonsoft.Json;

namespace Manuel_SoftwareDeveloperTest
{
    namespace Repositories
    {
        public class EmployeesRepository : IRepository
        {
            private readonly HttpClient _client;

            public EmployeesRepository()
            {
                _client = new HttpClient();
            }

            /// <summary>
            /// Consulta general del listado de trabajadores
            /// </summary>
            /// <returns>Lista completa del listado de trabajadores</returns>
            public Employees GetEmployees()
            {
                var uri = new Uri("http://dummy.restapiexample.com/api/v1/employees");
                var response = _client.GetAsync(uri).Result;

                if (response.StatusCode != System.Net.HttpStatusCode.TooManyRequests)
                {
                    var employees = JsonConvert.DeserializeObject<Employees>(response.Content.ReadAsStringAsync().Result);

                    var employeeData = new List<EmployeesData>();
                    foreach (var employee in employees.data)
                    {
                        employeeData.Add(employee);
                    }

                    return employees;
                }
                else
                {
                    var employeeData = new List<EmployeesData>
                    {
                        new EmployeesData
                        {
                            id = 0, employee_name = "NA", employee_salary = 0, employee_age = 0, profile_image = "NA"
                        }
                    };

                    var employees = new Employees()
                    {
                        data = employeeData.ToArray(),
                        message = "A problem occurred at the time of request, please try again later",
                        status = "Problems while obtaining data"
                    };

                    return employees;
                }


            }

            /// <summary>
            /// Obtencion de los datos del trabajador por ID 
            /// </summary>
            /// <param name="employeeId">Id del Trabajador que se quiere consultar</param>
            /// <returns>Datos del trabajador</returns>
            public EmployeesById GetEmployeeById(int employeeId)
            {
                var uri = new Uri("http://dummy.restapiexample.com/api/v1/employee/" + employeeId);
                var response = _client.GetAsync(uri).Result;

                if (response.StatusCode != System.Net.HttpStatusCode.TooManyRequests)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    var employee = JsonConvert.DeserializeObject<EmployeesById>(json);

                    return employee;
                }
                else
                {
                    var employeeData = new EmployeesDataById
                    {
                        id = 0,
                        employee_name = "NA",
                        employee_salary = 0,
                        employee_age = 0,
                        profile_image = "NA"
                    };

                    var employees = new EmployeesById
                    {
                        data = employeeData,
                        message = "A problem occurred at the time of request, please try again later",
                        status = "Problems while obtaining data"
                    };

                    return employees;
                }
            }

        }
    }
}