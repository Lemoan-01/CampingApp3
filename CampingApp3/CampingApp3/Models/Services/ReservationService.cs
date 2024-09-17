using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CampingApp3.Models.Data.Interfaces;

namespace CampingApp3.Models.Services
{
    public class ReservationService
    {
        private readonly IReservationRepository _reservationRepository;

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public void InsertReservation(int placeID, DateTime? dateStart, DateTime? dateEnd, int aantalPersonen, int userID, bool isBlock)
        {
            _reservationRepository.InsertReservation(placeID, dateStart, dateEnd, aantalPersonen, userID, isBlock);
        }

        public void DeleteReservation(int reservationID)
        {
            _reservationRepository.DeleteReservation(reservationID);
        }

        public void DeleteReservation(int userID, int placeID, DateTime startDate, DateTime endDate)
        {
            _reservationRepository.DeleteReservation(userID, placeID, startDate, endDate);
        }

        public List<int> GetReservationsByUserID(int userID)
        {
            return _reservationRepository.GetReservationsByUserID(userID);
        }

        public List<int> GetPlaceIDsByUserID(int userID)
        {
            return _reservationRepository.GetPlaceIDsByUserID(userID);
        }

        public int GetPlaceIDByReservationID(int reservationID)
        {
            return _reservationRepository.GetPlaceIDByReservationID(reservationID);
        }

        public bool isAvailable(int placeID, DateTime startDate, DateTime endDate)
        {
            return _reservationRepository.isAvailable(placeID, startDate, endDate);
        }



    }
}
