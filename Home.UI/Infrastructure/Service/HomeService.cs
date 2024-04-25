using Aplication.Service;
using Domain.Entitys.Home;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Domain.Model;
using Infrastructure.DataAccess;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Service
{
    public class HomeService : IHomeService
    {

        private readonly HomeDbContext _homeDbContext;

        public HomeService(HomeDbContext homeDbContext)
        {
            _homeDbContext = homeDbContext;
        }

        public async Task<Response<ConstructionMaterials>> CreateConstructionMaterialsAynce(ConstructionMaterials constructionMaterials)
        {
            try
            {
                await _homeDbContext.ConstructionMaterials.AddAsync(constructionMaterials);
                await _homeDbContext.SaveChangesAsync();
                return new Response<ConstructionMaterials>(constructionMaterials); 
            }
            catch (Exception ex)
            {
                return new Response<ConstructionMaterials>("Failed to create construction material: " + ex.Message);
            }
        }

        public async  Task<Response<HomeAppliance>> CreateHomeApplianceAynce(HomeAppliance homeAppliance)
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

        public async Task<Response<Home>> CreateHomeAynce(Home home)
        {
            try
            {
                await _homeDbContext.Homes.AddAsync(home);
                await _homeDbContext.SaveChangesAsync();
                return new Response<Home>(home);
            }
            catch (Exception ex)
            {
                return new Response<Home>("Failed to create home: " +  ex.Message);
            }
        }

        public async  Task<Response<HomeBuild>> CreateHomeBuildAynce(HomeBuild homeBuild)
        {
            try
            {
                await _homeDbContext.HomeBuilds.AddAsync(homeBuild);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeBuild>(homeBuild);
            }
            catch (Exception ex)
            {
                return new Response<HomeBuild>("Failed to create homeBuild: " + ex.Message);
            }
        }

        public async  Task<Response<HomeEquipment>> CreateHomeEquipmentAynce(HomeEquipment homeEquipment)
        {
            try
            {
                await _homeDbContext.HomeEquipment.AddAsync(homeEquipment);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeEquipment>(homeEquipment);
            }
            catch (Exception ex)
            {
                return new Response<HomeEquipment>("Failed to create homeEquipment: " + ex.Message);
            }
        }

        public async  Task<Response<HomeRent>> CreateHomeRentAynce(HomeRent homeRent)
        {
            try
            {
                await _homeDbContext.HomeRents.AddAsync(homeRent);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeRent>(homeRent);
            }
            catch (Exception ex)
            {
                return new Response<HomeRent>("Failed to create  homeRent: " + ex.Message);
            }
        }

        public async  Task<Response<HomeRepair>> CreateHomeRepairAynce(HomeRepair homeRepair)
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

        public async  Task<Response<Hotel>> CreateHotelAynce(Hotel hotel)
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

        public async  Task<Response<TechnicalServices>> CreateTechnicalServicesAynce(TechnicalServices technicalServices)
        {
            try
            {
                await _homeDbContext.TechnicalServices.AddAsync(technicalServices);
                await _homeDbContext.SaveChangesAsync();
                return new Response<TechnicalServices>(technicalServices);
            }
            catch (Exception ex)
            {
                return new Response<TechnicalServices>("Failed to create technicalService: " + ex.Message);
            }
        }

        public async  Task<Response<ConstructionMaterials>> DeleteConstructionMaterialsAynce(int Id)
        {
            var constructionMaterial = await _homeDbContext.ConstructionMaterials.FindAsync(Id);
            if (constructionMaterial == null)
            {
                return new Response<ConstructionMaterials>("Construction material not found.");
            }

            try
            {
                _homeDbContext.ConstructionMaterials.Remove(constructionMaterial);
                await _homeDbContext.SaveChangesAsync();
                return new Response<ConstructionMaterials>(constructionMaterial); 
            }
            catch (Exception ex)
            {
                return new Response<ConstructionMaterials>("Failed to delete construction material: " + ex.Message);
            }
        }

        public async  Task<Response<HomeAppliance>> DeleteHomeApplianceAynce(int Id)
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

        public async  Task<Response<Home>> DeleteHomeAynce(int Id)
        {
            var home = await _homeDbContext.Homes.FindAsync(Id);
            if (home  == null)
            {
                return new Response<Home>(" Home  not found.");
            }
            try
            {
                _homeDbContext.Homes.Remove(home);
                await _homeDbContext.SaveChangesAsync();
                return new Response<Home>(home);  
            }
            catch (Exception ex)
            {
                return new Response<Home>("Failed to delete  Home: " + ex.Message);
            }
        }

        public async  Task<Response<HomeBuild>> DeleteHomeBuildAynce(int Id)
        {
            var homebuild = await _homeDbContext.HomeBuilds.FindAsync(Id);
            if (homebuild == null)
            {
                return new Response<HomeBuild>("Home build  not found.");
            }

            try
            {
                _homeDbContext.HomeBuilds.Remove(homebuild );
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeBuild>(homebuild); 
            }
            catch (Exception ex)
            {
                return new Response<HomeBuild>("Failed to delete  Home build : " + ex.Message);
            }
        }

        public async  Task<Response<HomeEquipment>> DeleteHomeEquipmentAynce(int Id)
        {
            var homeEquipment  = await _homeDbContext.HomeEquipment.FindAsync(Id);
            if (homeEquipment == null)
            {
                return new Response<HomeEquipment>(" Home Equipment  not found.");
            }

            try
            {
                _homeDbContext.HomeEquipment.Remove(homeEquipment);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeEquipment>(homeEquipment); 
            }
            catch (Exception ex)
            {
                return new Response<HomeEquipment>("Failed to delete Home  Equipment : " + ex.Message);
            }
        }

        public async  Task<Response<HomeRent>> DeleteHomeRentAynce(int Id)
        {
            var homeRent = await _homeDbContext.HomeRents.FindAsync(Id);
            if (homeRent == null)
            {
                return new Response<HomeRent>(" Home Rent  not found.");
            }

            try
            {
                _homeDbContext.HomeRents.Remove(homeRent);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeRent>(homeRent); // Muvaffaqiyatli holat
            }
            catch (Exception ex)
            {
                return new Response<HomeRent>("Failed to delete home rent : " + ex.Message);
            }
        }

        public async  Task<Response<HomeRepair>> DeleteHomeRepairAynce(int Id)
        {
            var homeRepair = await _homeDbContext.HomeRepairs.FindAsync(Id);
            if (homeRepair == null)
            {
                return new Response<HomeRepair >("home Repair material not found.");
            }

            try
            {
                _homeDbContext.HomeRepairs.Remove(homeRepair);
                await _homeDbContext.SaveChangesAsync();
                return new Response< HomeRepair>(homeRepair); 
            }
            catch (Exception ex)
            {
                return new Response<HomeRepair>("Failed to delete  home Repair : " + ex.Message);
            }
        }

        public async  Task<Response<Hotel>> DeleteHotelAynce(int Id)
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

        public async  Task<Response<TechnicalServices>> DeleteTechnicalServicesAynce(int Id)
        {
            var techicalService  = await _homeDbContext.TechnicalServices.FindAsync(Id);
            if (techicalService == null)
            {
                return new Response<TechnicalServices>(" technical service  not found.");
            }

            try
            {
                _homeDbContext.TechnicalServices.Remove(techicalService);
                await _homeDbContext.SaveChangesAsync();
                return new Response<TechnicalServices>(techicalService); 
            }
            catch (Exception ex)
            {
                return new Response<TechnicalServices>("Failed to delete  technical service : " + ex.Message);
            }
        }

        public  async  Task<Response<List<ConstructionMaterials>>> GetAllConstructionMaterialsAynce()
        {
            try
            {
                var constructionMaterials = await _homeDbContext.ConstructionMaterials.ToListAsync();

                return new Response<List<ConstructionMaterials>>(constructionMaterials);
            }
            catch (Exception ex)
            {
                return new Response<List<ConstructionMaterials>>("Failed to get all construction materials: " + ex.Message);
            } 
        }

        public async  Task<Response<List<HomeAppliance>>> GetAllHomeApplianceAynce()
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

        public async  Task<Response<List<Home>>> GetAllHomeAynce()
        {
            try
            {
                var home = await _homeDbContext.Homes.ToListAsync();

                return new Response<List<Home>>(home);
            }
            catch (Exception ex)
            {
                return new Response<List<Home>>("Failed to get all home : " + ex.Message);
            }
        }

        public Task<Response<List<HomeBuild>>> GetAllHomeBuildAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<HomeEquipment>>> GetAllHomeEquipmentAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<HomeRent>>> GetAllHomeRentAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<HomeRepair>>> GetAllHomeRepairAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<Hotel>>> GetAllHotelAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<TechnicalServices>>> GetAllTechnicalServicesAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ConstructionMaterials>> GetByIdConstructionMaterialsAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeAppliance>> GetByIdHomeApplianceAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Home>> GetByIdHomeAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeBuild>> GetByIdHomeBuildAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeEquipment>> GetByIdHomeEquipmentAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRent>> GetByIdHomeRentAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRepair>> GetByIdHomeRepairAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Hotel>> GetByIdHotelAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<TechnicalServices>> GetByIdTechnicalServicesAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ConstructionMaterials>> UpdateConstructionMaterialsAynce(ConstructionMaterials constructionMaterials)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeAppliance>> UpdateHomeApplianceAynce(HomeAppliance homeAppliance)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Home>> UpdateHomeAynce(Home home)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeBuild>> UpdateHomeBuildAynce(HomeBuild homeBuild)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeEquipment>> UpdateHomeEquipmentAynce(HomeEquipment homeEquipment)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRent>> UpdateHomeRentAynce(HomeRent homeRent)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRepair>> UpdateHomeRepairAynce(HomeRepair homeRepair)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Hotel>> UpdateHotelAynce(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        public Task<Response<TechnicalServices>> UpdateTechnicalServicesAynce(TechnicalServices technicalServices)
        {
            throw new NotImplementedException();
        }
    }
}
