using Domain.Entitys.Regions.District;
using Domain.Entitys.Regions.Province;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home.Hotels
{
    public  class HotelBase
    {
        public int Id { get; set; }
        public long Price { get; set; }
        public string RoomType { get; set; }
        public string UserType { get; set; }   
        /// <summary>
        ///  user type  :   Male     
        ///  user type  :   Woman      
        ///  user type  :   Family       
        /// </summary>
        public string PhotoPath { get; set; }
        public int NumberOfRoom { get; set; }
        public ToshkentEnum AddressDistrict { get; set; }
        public ProvinceEnum AddressProvince { get; set; }
        public string InformationUniversal { get; set; }
        public long PhoneNumbers { get; set; }   /// 998900330402 

    }
}
