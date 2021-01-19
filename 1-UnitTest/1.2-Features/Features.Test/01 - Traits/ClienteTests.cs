using System;
using Features.Clients;
using Xunit;

namespace Features.Tests
{
    public class ClienteTests
    {
        [Fact(DisplayName = "New Valid Client")]
        [Trait("Features","Client Trait Tests")]
        public void Client_NewClient_ShouldBeValid()
        {
            // Arrange
            var cliente = new Client(
                Guid.NewGuid(),
                "Leonardo",
                "Costa",
                DateTime.Now.AddYears(-30),
                "leo@leo.com",
                true,
                DateTime.Now);

            // Act
            var result = cliente.IsValid();

            // Assert 
            Assert.True(result);
            Assert.Equal(0, cliente.ValidationResult.Errors.Count);
        }

        [Fact(DisplayName = "New Invalid Client")]
        [Trait("Features", "Client Trait Tests")]
        public void Client_NewClient_ShouldBeInvalid()
        {
            // Arrange
            var cliente = new Client(
                Guid.NewGuid(),
                "",
                "",
                DateTime.Now,
                "leo2leo.com",
                true,
                DateTime.Now);

            // Act
            var result = cliente.IsValid();

            // Assert 
            Assert.False(result);
            Assert.NotEqual(0, cliente.ValidationResult.Errors.Count);
        }
    }
}