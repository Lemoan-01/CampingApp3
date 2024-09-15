using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp3.Models.Data.Repositories
{
   public interface IReservationRepository
    {
        void InsertReservation(int placeID, DateTime? startDate, DateTime? endDate, int personAmount, int userID, bool isBlock);
        void DeleteReservation(int reservationID);
        void DeleteReservation(int userID, int placeID, DateTime startDate, DateTime endDate);
        List<int> GetReservationsByUserID(int userID);
        List<int> GetPlaceIDsByUserID(int userID);
        int GetPlaceIDByReservationID(int reservationID);
        bool isAvailable(int placeID, DateTime startDate, DateTime endDate);
    }
}
