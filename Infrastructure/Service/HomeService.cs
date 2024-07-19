using Aplication.Service;
using Domain.EntityDto.HomeDto;
using Domain.Entitys.Home;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Domain.Model;
using Infrastructure.DataAccess;
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
                return new Response<Home>("Failed to create home: " + ex.Message);
            }
        }

        public Task<Response<HomeDtoBase>> CreateHomeAynce(HomeCreateDto home)
        {
            throw new NotImplementedException();
        }



        public async Task<Response<HomeEquipment>> CreateHomeEquipmentAynce(HomeEquipment homeEquipment)
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

        public async Task<Response<HomeRent>> CreateHomeRentAynce(HomeRent homeRent)
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


       
        public async Task<Response<TechnicalServices>> CreateTechnicalServicesAynce(TechnicalServices technicalServices)
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

      
      

        public async Task<Response<Home>> DeleteHomeAynce(int Id)
        {
            var home = await _homeDbContext.Homes.FindAsync(Id);
            if (home == null)
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

     

        public async Task<Response<HomeEquipment>> DeleteHomeEquipmentAynce(int Id)
        {
            var homeEquipment = await _homeDbContext.HomeEquipment.FindAsync(Id);
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

        public async Task<Response<HomeRent>> DeleteHomeRentAynce(int Id)
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

       
        public async Task<Response<TechnicalServices>> DeleteTechnicalServicesAynce(int Id)
        {
            var techicalService = await _homeDbContext.TechnicalServices.FindAsync(Id);
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

        

       

        public async Task<Response<List<Home>>> GetAllHomeAynce()
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

  

        public async Task<Response<List<HomeEquipment>>> GetAllHomeEquipmentAynce()
        {
            try
            {
                var homeEquipment = await _homeDbContext.HomeEquipment.ToListAsync();

                return new Response<List<HomeEquipment>>(homeEquipment);
            }
            catch (Exception ex)
            {
                return new Response<List<HomeEquipment>>("Failed to get all home equipment : " + ex.Message);
            }
        }

        public async Task<Response<List<HomeRent>>> GetAllHomeRentAynce()
        {
            try
            {
                var homeRent = await _homeDbContext.HomeRents.ToListAsync();

                return new Response<List<HomeRent>>(homeRent);
            }
            catch (Exception ex)
            {
                return new Response<List<HomeRent>>("Failed to get all Home Rent: " + ex.Message);
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

        public async Task<Response<List<TechnicalServices>>> GetAllTechnicalServicesAynce()
        {
            try
            {
                var technicalService = await _homeDbContext.TechnicalServices.ToListAsync();

                return new Response<List<TechnicalServices>>(technicalService);
            }
            catch (Exception ex)
            {
                return new Response<List<TechnicalServices>>("Failed to get all TechnicalService: " + ex.Message);
            }
        }

      
        
        public async Task<Response<Home>> GetByIdHomeAynce(int Id)
        {
            try
            {
                var home = await _homeDbContext.Homes.FindAsync(Id);

                if (home == null)
                {
                    return new Response<Home>("Home   not found.");
                }

                return new Response<Home>(home);
            }
            catch (Exception ex)
            {
                return new Response<Home>("Failed to get home: " + ex.Message);
            }
        }


        public async Task<Response<HomeEquipment>> GetByIdHomeEquipmentAynce(int Id)
        {
            try
            {
                var homeEquipment = await _homeDbContext.HomeEquipment.FindAsync(Id);

                if (homeEquipment == null)
                {
                    return new Response<HomeEquipment>(" Home Equipment  not found.");
                }

                return new Response<HomeEquipment>(homeEquipment);
            }
            catch (Exception ex)
            {
                return new Response<HomeEquipment>("Failed to get  home Equipment: " + ex.Message);
            }
        }

        public async Task<Response<HomeRent>> GetByIdHomeRentAynce(int Id)
        {
            try
            {
                var homeRent = await _homeDbContext.HomeRents.FindAsync(Id);

                if (homeRent == null)
                {
                    return new Response<HomeRent>(" Home Rent not found.");
                }

                return new Response<HomeRent>(homeRent);
            }
            catch (Exception ex)
            {
                return new Response<HomeRent>("Failed to get Home  Rent : " + ex.Message);
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

        public async Task<Response<TechnicalServices>> GetByIdTechnicalServicesAynce(int Id)
        {
            try
            {
                var technicalService = await _homeDbContext.TechnicalServices.FindAsync(Id);

                if (technicalService == null)
                {
                    return new Response<TechnicalServices>(" TechnicalServices material not found.");
                }

                return new Response<TechnicalServices>(technicalService);
            }
            catch (Exception ex)
            {
                return new Response<TechnicalServices>("Failed to get technical service material: " + ex.Message);
            }
        }

     
  

        public async Task<Response<Home>> UpdateHomeAynce(Home home)
        {
            try
            {
                _homeDbContext.Homes.Update(home);
                await _homeDbContext.SaveChangesAsync();
                return new Response<Home>(home);
            }
            catch (Exception ex)
            {
                return new Response<Home>("Failed to update  Home: " + ex.Message);
            }
        }

       

        public async Task<Response<HomeEquipment>> UpdateHomeEquipmentAynce(HomeEquipment homeEquipment)
        {
            try
            {
                _homeDbContext.HomeEquipment.Update(homeEquipment);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeEquipment>(homeEquipment);
            }
            catch (Exception ex)
            {
                return new Response<HomeEquipment>("Failed to update  home equipment : " + ex.Message);
            }
        }

        public async Task<Response<HomeRent>> UpdateHomeRentAynce(HomeRent homeRent)
        {
            try
            {
                _homeDbContext.HomeRents.Update(homeRent);
                await _homeDbContext.SaveChangesAsync();
                return new Response<HomeRent>(homeRent);
            }
            catch (Exception ex)
            {
                return new Response<HomeRent>("Failed to update  home rent: " + ex.Message);
            }
        }

     
        public async Task<Response<Hotel>> UpdateHotelAynce(Hotel hotel)
        {
            try
            {
                _homeDbContext.Hotels.Update(hotel);
                await _homeDbContext.SaveChangesAsync();
                return new Response<Hotel>(hotel);
            }
            catch (Exception ex)
            {
                return new Response<Hotel>("Failed to update hotel: " + ex.Message);
            }
        }

        public async Task<Response<TechnicalServices>> UpdateTechnicalServicesAynce(TechnicalServices technicalServices)
        {
            try
            {
                _homeDbContext.TechnicalServices.Update(technicalServices);
                await _homeDbContext.SaveChangesAsync();
                return new Response<TechnicalServices>(technicalServices);
            }
            catch (Exception ex)
            {
                return new Response<TechnicalServices>("Failed to update technical Services: " + ex.Message);
            }
        }
    }
}
