using Domain.Entitys.Regions.District;
using Domain.Entitys.Regions.Province;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home.Services
{
    public  class ServiceBase
    {
        [Required]
        [StringLength(30)]
        public decimal Price { get; set; }
        [Column("moneyType")]
        public string MoneyType { get; set; }
        [Column("photoPath")]
        public string PhotoPath { get; set; }
        [Column("theemployerandemployee")]
        public string TheEmployerAndEmployee { get; set; }
        [Column("servicetype")]
        public string ServiceType { get; set; }
        [Column("addressdistrict")]
        public ToshkentEnum AddressDistrict { get; set; }
        [Column("addressprovince")]
        public ProvinceEnum AddressProvince { get; set; }
        [Column("informationuniversal")]
        public string InformationUniversal { get; set; }
        [Column("phonenumbers")]
        public string PhoneNumbers { get; set; }   /// 998900220407   
    }
}
