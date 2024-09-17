using Moq;
using NUnit.Framework;
using CampingApp3.Models.Data.Interfaces;
using CampingApp3.Models.Services;

namespace CampingApp3.Tests
{
    [TestFixture]
    public class PlaceServiceTests
    {
        private Mock<IPlaceRepository> _mockPlaceRepository;
        private PlaceService _placeService;

        [SetUp]
        public void SetUp()
        {
            _mockPlaceRepository = new Mock<IPlaceRepository>();
            _placeService = new PlaceService(_mockPlaceRepository.Object);
        }

        [Test]
        public void GetDescription_ReturnsValidDescription()
        {
            // Arrange
            var placeId = 1;
            var expectedDescription = "Surface: 100m²\nWater: Available\nElectricity: Available\nPrice: €50,- /day";
            _mockPlaceRepository.Setup(repo => repo.GetDescription(placeId))
                                .Returns(expectedDescription);

            // Act
            var result = _placeService.GetDescription(placeId);

            // Assert
            Assert.AreEqual(expectedDescription, result);
            _mockPlaceRepository.Verify(repo => repo.GetDescription(placeId), Times.Once);
        }

        [Test]
        public void IsBlockedOnID_ReturnsTrue()
        {
            // Arrange
            var placeId = 1;
            _mockPlaceRepository.Setup(repo => repo.IsBlockedOnID(placeId))
                                .Returns(true);

            // Act
            var result = _placeService.IsBlockedOnID(placeId);

            // Assert
            Assert.IsTrue(result);
            _mockPlaceRepository.Verify(repo => repo.IsBlockedOnID(placeId), Times.Once);
        }

        [Test]
        public void IsBlockedOnID_ReturnsFalse()
        {
            // Arrange
            var placeId = 1;
            _mockPlaceRepository.Setup(repo => repo.IsBlockedOnID(placeId))
                                .Returns(false);

            // Act
            var result = _placeService.IsBlockedOnID(placeId);

            // Assert
            Assert.IsFalse(result);
            _mockPlaceRepository.Verify(repo => repo.IsBlockedOnID(placeId), Times.Once);
        }

        [Test]
        public void GetImageFromDatabase_ReturnsImage()
        {
            // Arrange
            var placeId = 1;
            var expectedImage = new byte[] { 1, 2, 3, 4 };
            _mockPlaceRepository.Setup(repo => repo.GetImageFromDatabase(placeId))
                                .Returns(expectedImage);

            // Act
            var result = _placeService.GetImageFromDatabase(placeId);

            // Assert
            Assert.AreEqual(expectedImage, result);
            _mockPlaceRepository.Verify(repo => repo.GetImageFromDatabase(placeId), Times.Once);
        }

        [Test]
        public void GetImageFromDatabase_ReturnsNull_WhenNoImageExists()
        {
            // Arrange
            var placeId = 1;
            _mockPlaceRepository.Setup(repo => repo.GetImageFromDatabase(placeId))
                                .Returns((byte[])null);

            // Act
            var result = _placeService.GetImageFromDatabase(placeId);

            // Assert
            Assert.IsNull(result);
            _mockPlaceRepository.Verify(repo => repo.GetImageFromDatabase(placeId), Times.Once);
        }
    }
}
