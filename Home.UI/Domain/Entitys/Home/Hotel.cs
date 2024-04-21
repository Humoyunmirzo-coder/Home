using Domain.Entitys.Home.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home
{
    public  class Hotel : HotelBase
    {
        public int Id { get; set; }
        public string DayMonth { get; set; }         /// Day or month time 
    }
}
