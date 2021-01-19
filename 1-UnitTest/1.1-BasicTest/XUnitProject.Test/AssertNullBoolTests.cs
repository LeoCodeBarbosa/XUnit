using Xunit;

namespace XUnitProject.Test
{
    public class AssertNullBoolTests
    {
        [Fact]
        public void Employe_Name_ShouldNotBeNullOrEmpty()
        {
            // Arrange & Act
            var employe = new Employe("", 1000);

            // Assert
            Assert.False(string.IsNullOrEmpty(employe.Name));
        }

        [Fact]
        public void Employe_NickName_ShouldNotHaveNickName()
        {
            // Arrange & Act
            var employe = new Employe("Leonardo", 1000);

            // Assert
            Assert.Null(employe.NickName);

            // Assert Bool
            Assert.True(string.IsNullOrEmpty(employe.NickName));
            Assert.False(employe.NickName?.Length > 0);
        }
    }
}
