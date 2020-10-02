using System;
using NUnit.Framework;
using JsonPractice;

namespace JsonPracticeTest
{
    public class JsonTests
    {
       [Test]
        public void NonEmptyNameShouldBeSet()
        {
            var employee = new Employee {EmployeeName = "Vardhan"};
            Assert.AreEqual("Vardhan",employee.EmployeeName);
        }

        [Test]
        public void EmptyNameShouldNotBeSet()
        {
            var employee = new Employee();
            Assert.Throws<Exception>(() => employee.EmployeeName = "");
        }
    }
}