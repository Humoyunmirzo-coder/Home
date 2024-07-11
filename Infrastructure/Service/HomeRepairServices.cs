using Aplication.Service;
using Domain.Entitys.Home.Services;
using Domain.Model;
using Infrastructure.DataAccess;
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
        public Task<Response<HomeRepair>> DeleteHomeRepairAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<HomeRepair>>> GetAllHomeRepairAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRepair>> GetByIdHomeRepairAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRepair>> UpdateHomeRepairAynce(HomeRepair homeRepair)
        {
            throw new NotImplementedException();
        }
    }
}
