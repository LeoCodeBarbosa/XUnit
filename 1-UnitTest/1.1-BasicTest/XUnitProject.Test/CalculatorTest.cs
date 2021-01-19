using Xunit;

namespace XUnitProject.Test
{
    public class CalculatorTest
    {
        [Fact(DisplayName = "Sum_ReturnSumValue_Success")]
        [Trait("Class Category", "Calculator Tests")]
        public void Calculator_Sum_ReturnSumValue_Success()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Sum(2, 2);

            //Assert 
            Assert.Equal(4, result);
        }

        [Fact(DisplayName = "Sum_ReturnSumValue_Fail")]
        [Trait("Class Category", "Calculator Tests")]
        public void Calculator_Sum_ReturnSumValue_Fail()
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Sum(2, 7);

            //Assert 
            Assert.NotEqual(4, result);
        }


        [Theory(DisplayName = "Sum_ReturnCorrectSumValue")]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 4, 7)]
        [InlineData(9, 9, 18)]
        [InlineData(10, 100, 110)]
        [Trait("Class Category", "Calculator Tests")]
        public void Calculator_Sum_ReturnCorrectSumValue(double v1, double v2, double total)
        {
            //Arrange
            var calculator = new Calculator();

            //Act
            var result = calculator.Sum(v1, v2);

            //Assert 
            Assert.Equal(total, result);
        }

    }
}
