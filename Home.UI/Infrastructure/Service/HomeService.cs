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

        public Task<Response<HomeAppliance>> DeleteHomeApplianceAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Home>> DeleteHomeAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeBuild>> DeleteHomeBuildAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeEquipment>> DeleteHomeEquipmentAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRent>> DeleteHomeRentAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRepair>> DeleteHomeRepairAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Hotel>> DeleteHotelAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<TechnicalServices>> DeleteTechnicalServicesAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ConstructionMaterials>>> GetAllConstructionMaterialsAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<HomeAppliance>>> GetAllHomeApplianceAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<Home>>> GetAllHomeAynce()
        {
            throw new NotImplementedException();
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
