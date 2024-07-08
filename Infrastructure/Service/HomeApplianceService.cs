using Aplication.Service;
using Domain.Entitys.Home.SpareParts;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class HomeApplianceService : IHomeAppliance
    {
        public Task<Response<HomeAppliance>> CreateHomeApplianceAynce(HomeAppliance homeAppliance)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeAppliance>> DeleteHomeApplianceAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<HomeAppliance>>> GetAllHomeApplianceAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeAppliance>> GetByIdHomeApplianceAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeAppliance>> UpdateHomeApplianceAynce(HomeAppliance homeAppliance)
        {
            throw new NotImplementedException();
        }
    }
}
