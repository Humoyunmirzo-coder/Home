using Domain.Entitys.Home.SpareParts;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface IHomeEquipment
    {
        Task<Response<HomeEquipment>> CreateHomeEquipmentAynce(HomeEquipment homeEquipment);
        Task<Response<HomeEquipment>> DeleteHomeEquipmentAynce(int Id);
        Task<Response<HomeEquipment>> UpdateHomeEquipmentAynce(HomeEquipment homeEquipment);
        Task<Response<HomeEquipment>> GetByIdHomeEquipmentAynce(int Id);
        Task<Response<List<HomeEquipment>>> GetAllHomeEquipmentAynce();
    }
}
