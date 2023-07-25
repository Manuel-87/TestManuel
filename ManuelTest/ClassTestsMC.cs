using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manuel_SoftwareDeveloperTest.Class;
using Manuel_SoftwareDeveloperTest.Repositories;

namespace ManuelTest
{
    [TestClass]
    public class ClassTestsMC
    {
        [TestMethod]
        public void TestCalculatePeriodSalary()
        {
            var miscClass = new MiscClass(new EmployeesRepository()); 
            int employeeId = 12;
            int period = 3;
            int expectedSalary = 200000; 

            int actualSalary = miscClass.CalculatePeriodSalary(employeeId, period);

            Assert.AreEqual(expectedSalary, actualSalary, "The calculated salary is incorrect.");
        }
    }
}