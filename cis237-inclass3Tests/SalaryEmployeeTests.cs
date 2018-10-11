using Microsoft.VisualStudio.TestTools.UnitTesting;
using cis237_inclass3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_inclass3.Tests
{
    [TestClass()]
    public class SalaryEmployeeTests
    {
        [TestMethod()]
        public void FirstAndLastNameTest()
        {
            // Arrange
            SalaryEmployee testEmployee = MakeNewSalaryEmployee();
            string expected = "David Barnes";

            // Act
            string actual = testEmployee.FirstAndLastName();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FormattedSalaryTest()
        {
            // Arrange
            SalaryEmployee testEmployee = MakeNewSalaryEmployee();
            string expected = "$13,000.00";

            // Act
            string actual = testEmployee.FormattedSalary();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        private SalaryEmployee MakeNewSalaryEmployee()
        {
            return new SalaryEmployee("David", "Barnes", 250m);
        }
    }
}