using System;
using Xunit;

namespace XUnitProject.Test
{
    public class AssertingExceptionsTests
    {
        [Fact (DisplayName = "ShouldReturnErrorDivideByZero")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void Calculator_Divide_ShouldReturnErrorDivideByZero()
        {
            // Arrange
            var calculator = new Calculator();

            // Act & Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }


        [Fact (DisplayName = "ShouldReturnSalaryLessThanAllowed")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void Employe_Salary_ShouldReturnSalaryLessThanAllowed()
        {
            // Arrange & Act & Assert
            var exception =
                Assert.Throws<Exception>(() => EmployeFactory.Create("Leonardo", 250));

            Assert.Equal("Salary less than allowed", exception.Message);
        }
    }
}
