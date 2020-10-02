using System.IO;
using Newtonsoft.Json;
namespace JsonPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var employee = new Employee
            {
                Age = 10,
                EmployeeId = 1,
                EmployeeName = "Vardhan"
            };
            var serializedString = JsonConvert.SerializeObject(employee);
            WriteToFile(serializedString, @"C:\Bootcamp\OwnPractice\BootCampPractice\JsonPractice\employeeJson.json");

        }

        private static void WriteToFile(string serializedString, string path)
        {
            using var file = new StreamWriter(path);
            file.WriteLine(serializedString);
        }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
    }
}
