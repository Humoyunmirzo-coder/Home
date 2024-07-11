using Aplication.Service;
using Domain.Entitys.Home.Services;
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
    public class HomeRepairServices : IHomeRepair
    {
        private readonly HomeDbContext _homeDbContext;

        public HomeRepairServices(HomeDbContext homeDbContext)
        {
            _homeDbContext = homeDbContext;
        }


        public async Task<Response<HomeRepair>> CreateHomeRepairAynce(HomeRepair homeRepair)
        {
            try
            {
                await _homeDbContext.HomeRepairs.AddAsync(homeRepair);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeRepair>(homeRepair);
            }
            catch (Exception ex)
            {
                return new Response<HomeRepair>("Failed to create homeRepair: " + ex.Message);
            }
        }

        public async Task<Response<HomeRepair>> DeleteHomeRepairAynce(int Id)
        {
            var homeRepair = await _homeDbContext.HomeRepairs.FindAsync(Id);
            if (homeRepair == null)
            {
                return new Response<HomeRepair>("home Repair material not found.");
            }

            try
            {
                _homeDbContext.HomeRepairs.Remove(homeRepair);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeRepair>(homeRepair);
            }
            catch (Exception ex)
            {
                return new Response<HomeRepair>("Failed to delete  home Repair : " + ex.Message);
            }
        }


        public async Task<Response<List<HomeRepair>>> GetAllHomeRepairAynce()
        {
            try
            {
                var homeRepair = await _homeDbContext.HomeRepairs.ToListAsync();

                return new Response<List<HomeRepair>>(homeRepair);
            }
            catch (Exception ex)
            {
                return new Response<List<HomeRepair>>("Failed to get all home Repair : " + ex.Message);
            }
        }

        public async Task<Response<HomeRepair>> GetByIdHomeRepairAynce(int Id)
        {
            try
            {
                var homeRepair = await _homeDbContext.HomeRepairs.FindAsync(Id);

                if (homeRepair == null)
                {
                    return new Response<HomeRepair>(" Home Repair material not found.");
                }

                return new Response<HomeRepair>(homeRepair);
            }
            catch (Exception ex)
            {
                return new Response<HomeRepair>("Failed to get home  repair : " + ex.Message);
            }
        }

        public async Task<Response<HomeRepair>> UpdateHomeRepairAynce(HomeRepair homeRepair)
        {
            try
            {
                _homeDbContext.HomeRepairs.Update(homeRepair);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeRepair>(homeRepair);
            }
            catch (Exception ex)
            {
                return new Response<HomeRepair>("Failed to update home  repair: " + ex.Message);
            }
        }

    }
}
