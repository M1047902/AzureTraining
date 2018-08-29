using BusinessEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public interface IHotelRating
    {
        List<Hotel> GetAllHotels();
        List<string> GetCities();
        List<MenuItem> GetAllMenu();

    }
}
