using Domain.Entitys.Home.SpareParts;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface IConstructionMaterials
    {
        Task<Response<ConstructionMaterials>> CreateConstructionMaterialsAynce(ConstructionMaterials constructionMaterials);
        Task<Response<ConstructionMaterials>> DeleteConstructionMaterialsAynce(int Id);
        Task<Response<ConstructionMaterials>> UpdateConstructionMaterialsAynce(ConstructionMaterials constructionMaterials);
        Task<Response<ConstructionMaterials>> GetByIdConstructionMaterialsAynce(int Id);
        Task<Response<List<ConstructionMaterials>>> GetAllConstructionMaterialsAynce();
    }
}
