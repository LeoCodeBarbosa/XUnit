using Xunit;

namespace XUnitProject.Test
{
    public class AssertStringsTests
    {
        [Fact (DisplayName = "JoinNames_ReturnFullName")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void StringsTools_JoinNames_ReturnFullName()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var fullName = sut.Join("Leonardo", "Costa");

            // Assert
            Assert.Equal("Leonardo Costa", fullName);
        }



        [Fact (DisplayName = "JoinNames_ShouldIgnoreCase")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void StringsTools_JoinNames_ShouldIgnoreCase()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var fullName = sut.Join("Leonardo", "Costa");

            // Assert
            Assert.Equal("LEONARDO COSTA", fullName, true);
        }



        [Fact (DisplayName = "JoinNames_ShouldContainPartsOfName")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void StringsTools_JoinNames_ShouldContainPartsOfName()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var fullName = sut.Join("Leonardo", "Costa");

            // Assert
            Assert.Contains("ardo", fullName);
        }


        [Fact (DisplayName = "JoinNames_ShouldStartWith")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void StringsTools_JoinNames_ShouldStartWith()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var fullName = sut.Join("Leonardo", "Costa");

            // Assert
            Assert.StartsWith("Leo", fullName);
        }


        [Fact (DisplayName = "JoinNames_ShouldEndWith")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void StringsTools_JoinNames_ShouldEndWith()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var fullName = sut.Join("Leonardo", "Costa");

            // Assert
            Assert.EndsWith("sta", fullName);
        }


        [Fact (DisplayName = "JoinNames_ValidatedRegularExpression")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void StringsTools_JoinNames_ValidatedRegularExpression()
        {
            // Arrange
            var sut = new StringsTools();

            // Act
            var fullName = sut.Join("Leonardo", "Costa");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", fullName);
        }
    }
}
