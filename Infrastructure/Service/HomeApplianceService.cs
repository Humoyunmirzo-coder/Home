using Aplication.Service;
using Domain.Entitys.Home.SpareParts;
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
        public async Task<Response<HomeAppliance>> DeleteHomeApplianceAynce(int Id)
        {
            var homeAppliance = await _homeDbContext.HomeAppliances.FindAsync(Id);
            if (homeAppliance == null)
            {
                return new Response<HomeAppliance>("Home  Appliance not found.");
            }

            try
            {
                _homeDbContext.HomeAppliances.Remove(homeAppliance);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeAppliance>(homeAppliance);
            }
            catch (Exception ex)
            {
                return new Response<HomeAppliance>("Failed to delete Home Appliance: " + ex.Message);
            }
        }

        public async Task<Response<List<HomeAppliance>>> GetAllHomeApplianceAynce()
        {
            try
            {
                var homeAppliance = await _homeDbContext.HomeAppliances.ToListAsync();

                return new Response<List<HomeAppliance>>(homeAppliance);
            }
            catch (Exception ex)
            {
                return new Response<List<HomeAppliance>>("Failed to get all  home appliance: " + ex.Message);
            }
        }
        public async Task<Response<HomeAppliance>> GetByIdHomeApplianceAynce(int Id)
        {
            try
            {
                var homeAppliance = await _homeDbContext.HomeAppliances.FindAsync(Id);

                if (homeAppliance == null)
                {
                    return new Response<HomeAppliance>(" Home appliance  not found.");
                }

                return new Response<HomeAppliance>(homeAppliance);
            }
            catch (Exception ex)
            {
                return new Response<HomeAppliance>("Failed to get  Home Appliance : " + ex.Message);
            }
        }


        public Task<Response<HomeAppliance>> UpdateHomeApplianceAynce(HomeAppliance homeAppliance)
        {
            throw new NotImplementedException();
        }
    }
}
