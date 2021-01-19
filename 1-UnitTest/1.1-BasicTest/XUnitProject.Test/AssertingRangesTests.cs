using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitProject.Test
{
    public class AssertingRangesTests
    {
        [Theory (DisplayName = "SalaryRangeShouldRespectLevel")]
        [InlineData(700)]
        [InlineData(1500)]
        [InlineData(2000)]
        [InlineData(7500)]
        [InlineData(8000)]
        [InlineData(15000)]
        [Trait("Asserts", "Asserts Example Tests")]
        public void Employe_Salary_SalaryRangeShouldRespectProfessionalLevel(double salary)
        {
            // Arrange & Act
            var employe = new Employe("Leonardo", salary);

            // Assert
            if (employe.ProfessionalLevel == ProfessionalLevel.Junior)
                Assert.InRange(employe.Salary, 500, 1999);

            if (employe.ProfessionalLevel == ProfessionalLevel.Pleno)
                Assert.InRange(employe.Salary, 2000, 7999);

            if (employe.ProfessionalLevel == ProfessionalLevel.Senior)
                Assert.InRange(employe.Salary, 8000, double.MaxValue);

            Assert.NotInRange(employe.Salary, 0, 499);
        }
    }
}
