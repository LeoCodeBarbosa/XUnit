using System;
using Xunit;

namespace XUnitProject.Test
{
    public class AssertingExceptionsTests
    {
        [Fact]
        public void Calculator_Divide_ShouldReturnErrorDivideByZero()
        {
            // Arrange
            var calculator = new Calculator();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }


        [Fact]
        public void Employe_Salary_ShouldReturnSalaryLessThanAllowed()
        {
            // Arrange & Act & Assert
            var exception =
                Assert.Throws<Exception>(() => EmployeFactory.Create("Leonardo", 250));

            Assert.Equal("Salary less than allowed", exception.Message);
        }
    }
}
