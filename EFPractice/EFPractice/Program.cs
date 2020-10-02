using System.Linq;
using NLog;
namespace EFPractice
{
    class Program
    {
        protected Program()
        {

        }
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public static void Main(string[] args)
        {
            using (var dbContext = new EmployeeDatabaseEntities())
            {
                logger.Info("Starting looping the departments");
                var departmentsList = dbContext.Departments;
                foreach (var department in departmentsList)
                {
                    logger.Info($"Operatin on department {department.Name} at location {department.Location}");
                    var employeesList = department.Employees;
                    foreach (var employee in employeesList)
                    {
                        logger.Info($"Employee : Name = {employee.Name}, Email = {employee.Email}, Salary = {employee.Salary}");
                    }
                }

                var itEmployees = dbContext.Employees.AsQueryable().Where(emp => emp.Department.Name.Equals("IT"));
                foreach (var emp in itEmployees)
                {
                    logger.Info($"Employee in IT Depratment : {emp.Name}, {emp.Salary}");
                }

                dbContext.Departments.Add(new Department()
                {
                    Name = "Transport",
                    Location = "Delhi"
                });
            }
        }
    }
}
