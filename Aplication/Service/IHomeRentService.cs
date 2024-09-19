using Domain.Entitys.Home;
using Domain.Model;

namespace Aplication.Service
{
    public interface IHomeRentService
    {
        Task<Response<HomeRent>> CreateHomeRentAynce(HomeRent homeRent);
        Task<Response<HomeRent>> DeleteHomeRentAynce(int Id);
        Task<Response<HomeRent>> UpdateHomeRentAynce(HomeRent homeRent);
        Task<Response<HomeRent>> GetByIdHomeRentAynce(int Id);
        Task<Response<List<HomeRent>>> GetAllHomeRentAynce();
    }
}
