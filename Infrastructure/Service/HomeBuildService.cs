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
    public class HomeBuildService : IHomeBuild
    {
        public Task<Response<HomeBuild>> CreateHomeBuildAynce(HomeBuild homeBuild)
        {
            throw new NotImplementedException();
        }

        public Task<Response<bool>> DeleteHomeBuildAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<List<HomeBuild>>> GetAllHomeBuildAynce()
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeBuild>> GetByIdHomeBuildAynce(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<HomeBuild>> UpdateHomeBuildAynce(HomeBuild homeBuild)
        {
            throw new NotImplementedException();
        }
    }
}
