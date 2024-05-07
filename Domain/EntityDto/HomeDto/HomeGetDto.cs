using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.EntityDto.HomeDto
{
    public  class HomeGetDto  : HomeDtoBase
    {
        public int Id { get; set; }
        public string PhoneNumbers { get; set; }   /// 998900220407   
    }
}
