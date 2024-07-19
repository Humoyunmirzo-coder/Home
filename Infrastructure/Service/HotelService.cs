using Aplication.Service;
using Domain.Entitys.Home;
using Domain.Model;
using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
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


        public async Task<Response<Hotel>> DeleteHotelAynce(int Id)
        {
            var Hotel = await _homeDbContext.Hotels.FindAsync(Id);
            if (Hotel == null)
            {
                return new Response<Hotel>("hotel  not found.");
            }

            try
            {
                _homeDbContext.Hotels.Remove(Hotel);
                await _homeDbContext.SaveChangesAsync();
                return new Response<Hotel>(Hotel);
            }
            catch (Exception ex)
            {
                return new Response<Hotel>("Failed to delete hotel : " + ex.Message);
            }
        }

        public async Task<Response<List<Hotel>>> GetAllHotelAynce()
        {
            try
            {
                var hotel = await _homeDbContext.Hotels.ToListAsync();

                return new Response<List<Hotel>>(hotel);
            }
            catch (Exception ex)
            {
                return new Response<List<Hotel>>("Failed to get all  Hotel: " + ex.Message);
            }
        }

        public async Task<Response<Hotel>> GetByIdHotelAynce(int Id)
        {
            try
            {
                var hotel = await _homeDbContext.Hotels.FindAsync(Id);

                if (hotel == null)
                {
                    return new Response<Hotel>("Hotel   not found.");
                }

                return new Response<Hotel>(hotel);
            }
            catch (Exception ex)
            {
                return new Response<Hotel>("Failed to get Hotel: " + ex.Message);
            }
        }

        public Task<Response<Hotel>> UpdateHotelAynce(Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
