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
    }
}
