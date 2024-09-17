using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp3.Models.Data.Interfaces
{
    public interface IPlaceRepository
    {
        string GetDescription(int placeID);
        bool IsBlockedOnID(int placeID);
        byte[] GetImageFromDatabase(int placeID);
        bool UpdatePrice(int newPrice, int placeID);
    }
}
