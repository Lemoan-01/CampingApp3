using Moq;
using NUnit.Framework;
using MySqlConnector;
using CampingApp3.Models.Data.Interfaces;
using CampingApp3.Models.Data;
using System.Data;

namespace CampingApp3.Tests
{
    public class UserRepositoryTests
    {
        [Test]
        public void LoginVerification_Valid()
        {
            // Arrange
            var mockDbConnection = new Mock<IDatabaseConnection>();
            var mockDataTable = new DataTable();

            // Add a row with count = 1 to simulate a successful login
            mockDataTable.Columns.Add("COUNT(*)", typeof(int));
            mockDataTable.Rows.Add(1);

            // Set up mock ExecuteQuery method to return the DataTable
            mockDbConnection.Setup(db => db.ExecuteQuery(It.IsAny<string>(), It.IsAny<MySqlParameter[]>()))
                            .Returns(mockDataTable);

            var userRepository = new UserRepository(mockDbConnection.Object);

            // Act
            var result = userRepository.LoginVerification("valid@email.com", "validpassword");

            // Assert
            Assert.IsTrue(result);
        }
    }
       
}
