using Domain.Entitys.Home;
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




    }
}
