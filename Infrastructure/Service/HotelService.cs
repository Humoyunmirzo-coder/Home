using Aplication.Service;
using Domain.Entitys.Home;
using Domain.Model;
using Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class HotelService : IHotelService
    {
        private readonly HomeDbContext _homeDbContext;

        public async Task<Response<Hotel>> CreateHotelAynce(Hotel hotel)
        {
            try
            {
                await _homeDbContext.Hotels.AddAsync(hotel);
                await _homeDbContext.SaveChangesAsync();
                return new Response<Hotel>(hotel);
            }
            catch (Exception ex)
            {
                return new Response<Hotel>("Failed to create hotel: " + ex.Message);
            }
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
