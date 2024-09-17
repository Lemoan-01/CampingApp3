using Moq;
using NUnit.Framework;
using CampingApp3.Models.Data.Interfaces;
using CampingApp3.Models.Services;
using System;
using System.Collections.Generic;

namespace CampingApp3.Tests
{
    [TestFixture]
    public class ReservationServiceTests
    {
        private Mock<IReservationRepository> _mockReservationRepository;
        private ReservationService _reservationService;

        [SetUp]
        public void SetUp()
        {
            _mockReservationRepository = new Mock<IReservationRepository>();
            _reservationService = new ReservationService(_mockReservationRepository.Object);
        }

        [Test]
        public void InsertReservation_CallsRepository()
        {
            // Arrange
            int placeID = 1;
            DateTime? dateStart = DateTime.Now;
            DateTime? dateEnd = DateTime.Now.AddDays(2);
            int aantalPersonen = 4;
            int userID = 123;
            bool isBlock = true;

            // Act
            _reservationService.InsertReservation(placeID, dateStart, dateEnd, aantalPersonen, userID, isBlock);

            // Assert
            _mockReservationRepository.Verify(repo => repo.InsertReservation(placeID, dateStart, dateEnd, aantalPersonen, userID, isBlock), Times.Once);
        }

        [Test]
        public void DeleteReservationByID_CallsRepository()
        {
            // Arrange
            int reservationID = 5;

            // Act
            _reservationService.DeleteReservation(reservationID);

            // Assert
            _mockReservationRepository.Verify(repo => repo.DeleteReservation(reservationID), Times.Once);
        }

        [Test]
        public void DeleteReservationWithDetails_CallsRepository()
        {
            // Arrange
            int userID = 123;
            int placeID = 1;
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(3);

            // Act
            _reservationService.DeleteReservation(userID, placeID, startDate, endDate);

            // Assert
            _mockReservationRepository.Verify(repo => repo.DeleteReservation(userID, placeID, startDate, endDate), Times.Once);
        }

        [Test]
        public void GetReservationsByUserID_ReturnsReservationIDs()
        {
            // Arrange
            int userID = 123;
            var expectedReservationIDs = new List<int> { 1, 2, 3 };
            _mockReservationRepository.Setup(repo => repo.GetReservationsByUserID(userID))
                                      .Returns(expectedReservationIDs);

            // Act
            var result = _reservationService.GetReservationsByUserID(userID);

            // Assert
            Assert.AreEqual(expectedReservationIDs, result);
            _mockReservationRepository.Verify(repo => repo.GetReservationsByUserID(userID), Times.Once);
        }

        [Test]
        public void GetPlaceIDsByUserID_ReturnsPlaceIDs()
        {
            // Arrange
            int userID = 123;
            var expectedPlaceIDs = new List<int> { 10, 20, 30 };
            _mockReservationRepository.Setup(repo => repo.GetPlaceIDsByUserID(userID))
                                      .Returns(expectedPlaceIDs);

            // Act
            var result = _reservationService.GetPlaceIDsByUserID(userID);

            // Assert
            Assert.AreEqual(expectedPlaceIDs, result);
            _mockReservationRepository.Verify(repo => repo.GetPlaceIDsByUserID(userID), Times.Once);
        }

        [Test]
        public void GetPlaceIDByReservationID_ReturnsCorrectPlaceID()
        {
            // Arrange
            int reservationID = 5;
            int expectedPlaceID = 42;
            _mockReservationRepository.Setup(repo => repo.GetPlaceIDByReservationID(reservationID))
                                      .Returns(expectedPlaceID);

            // Act
            var result = _reservationService.GetPlaceIDByReservationID(reservationID);

            // Assert
            Assert.AreEqual(expectedPlaceID, result);
            _mockReservationRepository.Verify(repo => repo.GetPlaceIDByReservationID(reservationID), Times.Once);
        }

        [Test]
        public void IsAvailable_ReturnsTrueWhenAvailable()
        {
            // Arrange
            int placeID = 1;
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(2);
            _mockReservationRepository.Setup(repo => repo.isAvailable(placeID, startDate, endDate))
                                      .Returns(true);

            // Act
            var result = _reservationService.isAvailable(placeID, startDate, endDate);

            // Assert
            Assert.IsTrue(result);
            _mockReservationRepository.Verify(repo => repo.isAvailable(placeID, startDate, endDate), Times.Once);
        }

        [Test]
        public void IsAvailable_ReturnsFalseWhenNotAvailable()
        {
            // Arrange
            int placeID = 1;
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now.AddDays(2);
            _mockReservationRepository.Setup(repo => repo.isAvailable(placeID, startDate, endDate))
                                      .Returns(false);

            // Act
            var result = _reservationService.isAvailable(placeID, startDate, endDate);

            // Assert
            Assert.IsFalse(result);
            _mockReservationRepository.Verify(repo => repo.isAvailable(placeID, startDate, endDate), Times.Once);
        }
    }
}
