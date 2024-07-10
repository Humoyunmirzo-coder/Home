using Aplication.Service;
using Domain.Entitys.Home.SpareParts;
using Domain.Model;
using Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class HomeApplianceService : IHomeAppliance
    {
        private readonly HomeDbContext _homeDbContext;

        public HomeApplianceService(HomeDbContext homeDbContext)
        {
            _homeDbContext = homeDbContext;
        }

        public async Task<Response<HomeAppliance>> CreateHomeApplianceAynce(HomeAppliance homeAppliance)
        {
            try
            {
                await _homeDbContext.HomeAppliances.AddAsync(homeAppliance);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeAppliance>(homeAppliance);
            }
            catch (Exception ex)
            {
                return new Response<HomeAppliance>("Failed to create  homeAppliance: " + ex.Message);
            }
        }
        public Task<Response<HomeAppliance>> DeleteHomeApplianceAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<HomeAppliance>>> GetAllHomeApplianceAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeAppliance>> GetByIdHomeApplianceAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeAppliance>> UpdateHomeApplianceAynce(HomeAppliance homeAppliance)
        {
            throw new NotImplementedException();
        }
    }
}
