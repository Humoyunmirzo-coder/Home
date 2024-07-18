using Aplication.Service;
using Domain.Entitys.Home;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class HotelService : IHotelService
    {
        private readonly IHotelService _service;

        public HotelService(IHotelService service)
        {
            _service = service;
        }

        public Task<Response<Hotel>> CreateHotelAynce(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Hotel>> DeleteHotelAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<Hotel>>> GetAllHotelAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<Hotel>> GetByIdHotelAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Hotel>> UpdateHotelAynce(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
