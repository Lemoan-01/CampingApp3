using CampingApp3.Models.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Printing;

namespace CampingApp3.Models.Services
{
    public class PlaceService
    {
        private readonly IPlaceRepository _placeRepository;
        public PlaceService(IPlaceRepository placeRepository)
        {
            _placeRepository = placeRepository;
        }

        public string GetDescription(int placeId)
        {
            return _placeRepository.GetDescription(placeId);
        }
        public bool IsBlockedOnID(int placeID)
        {
            return _placeRepository.IsBlockedOnID(placeID);
        }

        public byte[] GetImageFromDatabase(int placeID)
        {
            return _placeRepository.GetImageFromDatabase(placeID);
        }

        public bool UpdatePrice(int newPrice, int placeID)
        {
            return _placeRepository.UpdatePrice(newPrice, placeID);
        }

    }
}