using Domain.Entitys.Regions.District;
using Domain.Entitys.Regions.Province;

namespace Domain.Entitys.Home.Home
{
    public class HomeBase
    {
        public int Id { get; set; }
        public int Arena { get; set; }
        public long Price { get; set; }
        public int YearBuilt { get; set; }
        public string HomeType { get; set; }
        public string PhotoPath { get; set; }
        public int NumberOfRoom { get; set; }
        public ToshkentEnum AddressDistrict { get; set; }
        public ProvinceEnum AddressProvince { get; set; }
        public string InformationUniversal { get; set; }
        public long PhoneNumbers { get; set; }   /// 998900220407   


    }
}
