using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitProject.Test
{
    public class AssertingObjectTypesTests
    {
        [Fact (DisplayName = "ShouldReturnTypeOfEmploye")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void EmployeFactory_Create_ShouldReturnTypeOfEmploye()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 10000);

            // Assert
            Assert.IsType<Employe>(employe);
        }

        [Fact (DisplayName = "ShouldReturnPersonTypeDerivation")]
        [Trait("Asserts", "Asserts Example Tests")]
        public void EmployeFactory_Create_ShouldReturnPersonTypeDerivation()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 10000);

            // Assert
            Assert.IsAssignableFrom<Person>(employe);
        }
    }
}
