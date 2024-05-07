using Domain.Entitys.Home.Services;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public interface IHomeBuild
    {
        Task<Response<HomeBuild>> CreateHomeBuildAynce(HomeBuild homeBuild);
        Task<Response<bool>> DeleteHomeBuildAynce(int Id);
        Task<Response<HomeBuild>> UpdateHomeBuildAynce(HomeBuild homeBuild);
        Task<Response<HomeBuild>> GetByIdHomeBuildAynce(int Id);
        Task<Response<List<HomeBuild>>> GetAllHomeBuildAynce();
    }
}
