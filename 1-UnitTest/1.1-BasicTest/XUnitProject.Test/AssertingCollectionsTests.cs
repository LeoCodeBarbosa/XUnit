using Xunit;

namespace XUnitProject.Test
{
    public class AssertingCollectionsTests
    {
        [Fact (DisplayName = "Skills ShouldNotHaveEmptySkills")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void Employe_Skills_ShouldNotHaveEmptySkills()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 10000);

            // Assert
            Assert.All(employe.Skills, skills => Assert.False(string.IsNullOrWhiteSpace(skills)));
        }

        [Fact (DisplayName = "Skills JuniorShouldHaveBasicSkills")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void Employe_Skills_JuniorShouldHaveBasicSkills()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 1000);

            // Assert
            Assert.Contains("OOP", employe.Skills);
        }


        [Fact (DisplayName = "Skills JuniorShouldNotHaveAdvancedSkills")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void Employe_Skills_JuniorShouldNotHaveAdvancedSkills()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 1000);

            // Assert
            Assert.DoesNotContain("Microservices", employe.Skills);
        }


        [Fact (DisplayName = "Skills SeniorShouldHaveAllSkills")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void Employe_Skills_SeniorShouldHaveAllSkills()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 15000);

            var basciSkills = new[]
            {
                "Programming logic",
                "OOP",
                "Tests",
                "Microservices"
            };

            // Assert
            Assert.Equal(basciSkills, employe.Skills);
        }
    }
}
