using Aplication.Service;
using Domain.Entitys.Home.Services;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class HomeRepairServices : IHomeRepair
    {
        public Task<Response<HomeRepair>> CreateHomeRepairAynce(HomeRepair homeRepair)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRepair>> DeleteHomeRepairAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<HomeRepair>>> GetAllHomeRepairAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRepair>> GetByIdHomeRepairAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeRepair>> UpdateHomeRepairAynce(HomeRepair homeRepair)
        {
            throw new NotImplementedException();
        }
    }
}
