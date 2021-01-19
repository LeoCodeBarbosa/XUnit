using Xunit;

namespace XUnitProject.Test
{
    public class AssertNumbersTests
    {
        [Fact (DisplayName = "Sum_ShouldNotBeEqual")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void Calculator_Sum_ShouldBeEqual()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Sum(1, 2);

            // Assert
            Assert.Equal(3, result);
        }

        [Fact (DisplayName = "Sum_ShouldNotBeEqual")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void Calculator_Sum_ShouldNotBeEqual()
        {
            // Arrange
            var calculator = new Calculator();

            // Act
            var result = calculator.Sum(1.13123123123, 2.2312313123);

            // Assert
            Assert.NotEqual(expected: 3.3, actual: result, precision: 1);
        }
    }
}
