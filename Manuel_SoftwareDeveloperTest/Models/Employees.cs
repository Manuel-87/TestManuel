namespace Manuel_SoftwareDeveloperTest.Models
{

    public class Employees
    {
        public string status { get; set; }
        public EmployeesData[] data { get; set; }
        public string message { get; set; }

    }

    public class EmployeesData
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public int employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }
    }

    public class EmployeesById
    {
        public string status { get; set; }
        public EmployeesDataById data { get; set; }
        public string message { get; set; }

    }

    public class EmployeesDataById
    {
        public int id { get; set; }
        public string employee_name { get; set; }
        public int employee_salary { get; set; }
        public int employee_age { get; set; }
        public string profile_image { get; set; }
    }
}