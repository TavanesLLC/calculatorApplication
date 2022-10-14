using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace DataDrivenApplication.Test
{
    [TestClass]
    public class EmployeeTests

    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.xml",
            "Employees.xml",
            "Employee",DataAccessMethod.Sequential)]
        public void DataDrivenEmployeeTest()
        {
            Employee employee = new Employee();
            employee.Name = TestContext.DataRow["Name"]
                .ToString();
            employee.Email = TestContext.DataRow["Email"].ToString();
            Assert.IsNotNull(employee.Name);
            Assert.IsNotNull(employee.Email);
        }
    }
}