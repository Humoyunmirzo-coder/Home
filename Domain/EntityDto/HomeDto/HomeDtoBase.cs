using Domain.Entitys.Regions.District;
using Domain.Entitys.Regions.Province;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EntityDto.HomeDto
{
    public  class HomeDtoBase 
    {
        public double Arena { get; set; }
        public decimal Price { get; set; }
        public int NumberOfRoom { get; set; }
        public string PhoneNumbers { get; set; }   /// 998900220407   
    }
}
