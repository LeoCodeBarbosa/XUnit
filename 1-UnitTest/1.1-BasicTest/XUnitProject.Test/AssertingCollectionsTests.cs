using Xunit;

namespace XUnitProject.Test
{
    public class AssertingCollectionsTests
    {
        [Fact]
        public void Employe_Skills_ShouldNotHaveEmptySkills()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 10000);

            // Assert
            Assert.All(employe.Skills, skills => Assert.False(string.IsNullOrWhiteSpace(skills)));
        }

        [Fact]
        public void Employe_Skills_JuniorShouldHaveBasicSkills()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 1000);

            // Assert
            Assert.Contains("OOP", employe.Skills);
        }


        [Fact]
        public void Employe_Skills_JuniorShouldNotHaveAdvancedSkills()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 1000);

            // Assert
            Assert.DoesNotContain("Microservices", employe.Skills);
        }


        [Fact]
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
