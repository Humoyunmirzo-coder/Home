using Domain.Entitys.Home.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home
{
    public  class HomeRent : HomeRentBase
    {
        public int Id { get; set; }
        public bool HomeOwner { get; set; }           ///  With or without a landlord 
    }
}
