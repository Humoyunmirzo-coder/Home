using Domain.Entitys.Home.SpareParts;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface IHomeAppliance
    {
        Task<Response<HomeAppliance>> CreateHomeApplianceAynce(HomeAppliance homeAppliance);
        Task<Response<HomeAppliance>> DeleteHomeApplianceAynce(int Id);
        Task<Response<HomeAppliance>> UpdateHomeApplianceAynce(HomeAppliance homeAppliance);
        Task<Response<HomeAppliance>> GetByIdHomeApplianceAynce(int Id);
        Task<Response<List<HomeAppliance>>> GetAllHomeApplianceAynce();
    }
}
