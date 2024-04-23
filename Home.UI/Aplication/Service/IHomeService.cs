using Domain.Entitys.Home;
using Domain.Entitys.Home.Services;
using Domain.Entitys.Home.SpareParts;
using Domain.Model;

namespace Aplication.Service
{
    public interface IHomeService
    {
        Task<Response<Home>> CreateHomeAynce(Home home);
        Task<Response<Home>> DeleteHomeAynce(int Id);
        Task<Response<Home>> UpdateHomeAynce(Home home);
        Task<Response<Home>> GetByIdHomeAynce(int Id);
        Task<Response<List<Home>>> GetAllHomeAynce();


        Task<Response<HomeRent>> CreateHomeRentAynce(Home home);
        Task<Response<HomeRent>> DeleteHomeRentAynce(int Id);
        Task<Response<HomeRent>> UpdateHomeRentAynce(Home home);
        Task<Response<HomeRent>> GetByIdHomeRentAynce(int Id);
        Task<Response<List<HomeRent>>> CreateHomeRentAynce();


         Task<Response<Hotel>> CreateHotelAynce(Home home);
        Task<Response<Hotel>> DeleteHotelAynce(int Id);
        Task<Response<Hotel>> UpdateHotelAynce(Home home);
        Task<Response<Hotel>> GetByIdHotelAynce(int Id);
        Task<Response<List<Hotel>>> CreateHotelAynce();
        
        
        
        
        Task<Response<HomeBuild>> CreateHomeBuildAynce(Home home);
        Task<Response<HomeBuild>> DeleteHomeBuildAynce(int Id);
        Task<Response<HomeBuild>> UpdateHomeBuildAynce(Home home);
        Task<Response<HomeBuild>> GetByIdHomeBuildAynce(int Id);
        Task<Response<List<HomeBuild>>> CreateHomeBuildAynce();
               

        Task<Response<HomeRepair>> CreateHomeRepairAynce(Home home);
        Task<Response<HomeRepair>> DeleteHomeRepairAynce(int Id);
        Task<Response<HomeRepair>> UpdateHomeRepairAynce(Home home);
        Task<Response<HomeRepair>> GetByIdHomeRepairAynce(int Id);
        Task<Response<List<HomeRepair>>> CreateHomeRepairAynce();
        

        Task<Response<TechnicalServices>> CreateTechnicalServicesAynce(Home home);
        Task<Response<TechnicalServices>> DeleteTechnicalServicesAynce(int Id);
        Task<Response<TechnicalServices>> UpdateTechnicalServicesAynce(Home home);
        Task<Response<TechnicalServices>> GetByIdTechnicalServicesAynce(int Id);
        Task<Response<List<TechnicalServices>>> CreateTechnicalServicesAynce();

  



    }
}
