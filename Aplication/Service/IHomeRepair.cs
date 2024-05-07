using Domain.Entitys.Home.Services;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface IHomeRepair
    {
        Task<Response<HomeRepair>> CreateHomeRepairAynce(HomeRepair homeRepair);
        Task<Response<HomeRepair>> DeleteHomeRepairAynce(int Id);
        Task<Response<HomeRepair>> UpdateHomeRepairAynce(HomeRepair homeRepair);
        Task<Response<HomeRepair>> GetByIdHomeRepairAynce(int Id);
        Task<Response<List<HomeRepair>>> GetAllHomeRepairAynce();
    }
}
