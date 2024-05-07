using Domain.Entitys.Home;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface IHotelService
    {
        Task<Response<Hotel>> CreateHotelAynce(Hotel hotel);
        Task<Response<Hotel>> DeleteHotelAynce(int Id);
        Task<Response<Hotel>> UpdateHotelAynce(Hotel hotel);
        Task<Response<Hotel>> GetByIdHotelAynce(int Id);
        Task<Response<List<Hotel>>> GetAllHotelAynce();
    }
}
