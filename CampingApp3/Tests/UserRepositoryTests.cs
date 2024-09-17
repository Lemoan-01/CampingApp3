using Moq;
using NUnit.Framework;
using MySqlConnector;
using CampingApp3.Models.Data.Repositories;
using CampingApp3.Models.Data;

[TestFixture]
public class UserRepositoryTests
{
    private Mock<IDatabaseConnection> _mockDbConnection;
    private Mock<MySqlConnection> _mockConnection;
    private Mock<MySqlCommand> _mockCommand;
    private Mock<MySqlDataReader> _mockReader;
    private UserRepository _userRepository;

    [SetUp]
    public void Setup()
    {
        // Set up the mocks
        _mockDbConnection = new Mock<IDatabaseConnection>();
        _mockConnection = new Mock<MySqlConnection>();
        _mockCommand = new Mock<MySqlCommand>();
        _mockReader = new Mock<MySqlDataReader>();

        // Configure the mock database connection
        _mockDbConnection.Setup(db => db.CreateConnection()).Returns(_mockConnection.Object);

        // Configure the command behavior
        _mockConnection.Setup(conn => conn.CreateCommand()).Returns(_mockCommand.Object);
        _mockCommand.Setup(cmd => cmd.ExecuteReader()).Returns(_mockReader.Object);

        // Initialize the repository with the mock database connection
        _userRepository = new UserRepository(_mockDbConnection.Object);
    }

    [Test]
    public void GetEmail_ShouldReturnCorrectEmail()
    {
        // Arrange
        int testUserId = 1;
        string expectedEmail = "test@example.com";

        // Mock the data reader to return a result with an email
        _mockReader.Setup(reader => reader.Read()).Returns(true);
        _mockReader.Setup(reader => reader["email"]).Returns(expectedEmail);

        // Act
        var result = _userRepository.GetEmail(testUserId);

        // Assert
        Assert.AreEqual(expectedEmail, result);
    }

    [Test]
    public void GetEmail_WhenUserDoesNotExist_ShouldReturnNull()
    {
        // Arrange
        int testUserId = 1;

        // Mock the data reader to return no results
        _mockReader.Setup(reader => reader.Read()).Returns(false);

        // Act
        var result = _userRepository.GetEmail(testUserId);

        // Assert
        Assert.IsNull(result);
    }
}
