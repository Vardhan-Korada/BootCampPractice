using System;
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
        private string _employeeName;
        private int _age;
        public int EmployeeId { get; set; }

        public string EmployeeName
        {
            get => _employeeName;
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                    throw new Exception("Name cannot be empty");
                _employeeName = value;
            }
        }

        public int Age
        {
            get => _age;
            set
            {
                if(value < 0)
                    throw  new  Exception("Age cannot be empty");
                _age = value;
            }
        }
    }
}
