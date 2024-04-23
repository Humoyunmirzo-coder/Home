using Domain.Entitys.Home;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Service
{
    public  interface IHomeService 
    {
        Task<Response < Home>> CreateHomeAynce (Home home);
        Task<Response < Home>> DeleteHomeAynce (int  Id);
        Task<Response < Home>> UpdateHomeAynce ( Home home );
        Task<Response < Home>> GetByIdHomeAynce (int  Id);
        Task<Response <List< Home>>> GetAllHomeAynce ();




    }
}
