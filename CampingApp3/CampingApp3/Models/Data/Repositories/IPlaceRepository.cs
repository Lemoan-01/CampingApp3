using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampingApp3.Models.Data.Repositories
{
    public interface IPlaceRepository
    {
        string GetDescription(int placeID);
        bool IsBlockedOnID(int placeID);
        byte[] GetImageFromDatabase(int placeID);
    }
}
