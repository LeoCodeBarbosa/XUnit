using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitProject.Test
{
    public class AssertingObjectTypesTests
    {
        [Fact]
        public void EmployeFactory_Create_ShouldReturnTypeOfEmploye()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 10000);

            // Assert
            Assert.IsType<Employe>(employe);
        }

        [Fact]
        public void EmployeFactory_Create_ShouldReturnPersonTypeDerivation()
        {
            // Arrange & Act
            var employe = EmployeFactory.Create("Leonardo", 10000);

            // Assert
            Assert.IsAssignableFrom<Person>(employe);
        }
    }
}
