using Domain.Entitys.Regions.District;
using Domain.Entitys.Regions.Province;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home
{
    public class HomeBase
    {
        public int Id { get; set; }
        public int Arena { get; set; }
        public long Price { get; set; }
        public string PhotoPath { get; set; }
        public string AddressDistrict { get; set; }
        public string InformationUniversal { get; set; }
        public string PhoneNumber { get; set; }   /// 998900220407
    }
}
