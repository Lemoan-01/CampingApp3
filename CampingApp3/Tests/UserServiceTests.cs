using Moq;
using NUnit.Framework;
using CampingApp3.Models.Data.Interfaces;
using CampingApp3.Models.Services;
using System.Data;
using MySqlConnector;

namespace CampingApp3.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        private Mock<IUserRepository> _mockUserRepository;
        private UserService _userService;

        [SetUp]
        public void SetUp()
        {
            _mockUserRepository = new Mock<IUserRepository>();
            _userService = new UserService(_mockUserRepository.Object);
        }

        [Test]
        public void LoginVerification_Valid()
        {
            // Arrange
            _mockUserRepository.Setup(repo => repo.LoginVerification(It.IsAny<string>(), It.IsAny<string>()))
                               .Returns(true);

            // Act
            var result = _userService.LoginVerification("valid@email.com", "validpassword");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void LoginVerification_Failed()
        {
            // Arrange
            _mockUserRepository.Setup(repo => repo.LoginVerification(It.IsAny<string>(), It.IsAny<string>()))
                               .Returns(false);

            // Act
            var result = _userService.LoginVerification("invalid@email.com", "invalidpassword");

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void GetEmail_Valid()
        {
            // Arrange
            var expectedEmail = "test@example.com";
            _mockUserRepository.Setup(repo => repo.GetEmail(It.IsAny<int>()))
                               .Returns(expectedEmail);

            // Act
            var result = _userService.GetEmail(1);

            // Assert
            Assert.AreEqual(expectedEmail, result);
        }

        [Test]
        public void Register_Success()
        {
            // Arrange
            var email = "test@example.com";
            var phoneNumber = 1234567890;
            var password = "password";

            // Act
            TestDelegate act = () => _userService.Register(email, phoneNumber, password);

            // Assert
            Assert.DoesNotThrow(act);
            _mockUserRepository.Verify(repo => repo.Register(email, phoneNumber, password), Times.Once);
        }
    }
}
