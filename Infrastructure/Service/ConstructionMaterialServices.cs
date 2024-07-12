using Aplication.Service;
using Domain.Entitys.Home.SpareParts;
using Domain.Model;
using Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Service
{
    public class ConstructionMaterialServices : IConstructionMaterials
    {
        private readonly HomeDbContext _homeDbContext;

        public ConstructionMaterialServices(HomeDbContext homeDbContext)
        {
            _homeDbContext = homeDbContext;
        }

        public async Task<Response<ConstructionMaterials>> CreateConstructionMaterialsAynce(ConstructionMaterials constructionMaterials)
        {
            try
            {
                await _homeDbContext.ConstructionMaterials.AddAsync(constructionMaterials);
                await _homeDbContext.SaveChangesAsync();
                return new Response<ConstructionMaterials>(constructionMaterials);
            }
            catch (Exception ex)
            {
                return new Response<ConstructionMaterials>("Failed to create construction material: " + ex.Message);
            }
        }

        public Task<Response<ConstructionMaterials>> DeleteConstructionMaterialsAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<ConstructionMaterials>>> GetAllConstructionMaterialsAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<ConstructionMaterials>> GetByIdConstructionMaterialsAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<ConstructionMaterials>> UpdateConstructionMaterialsAynce(ConstructionMaterials constructionMaterials)
        {
            throw new NotImplementedException();
        }
    }
}
