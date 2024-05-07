using Domain.Entitys.Home.Services;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface ITechnicalServices
    {
        Task<Response<TechnicalServices>> CreateTechnicalServicesAynce(TechnicalServices technicalServices);
        Task<Response<TechnicalServices>> DeleteTechnicalServicesAynce(int Id);
        Task<Response<TechnicalServices>> UpdateTechnicalServicesAynce(TechnicalServices technicalServices);
        Task<Response<TechnicalServices>> GetByIdTechnicalServicesAynce(int Id);
        Task<Response<List<TechnicalServices>>> GetAllTechnicalServicesAynce();
    }
}
