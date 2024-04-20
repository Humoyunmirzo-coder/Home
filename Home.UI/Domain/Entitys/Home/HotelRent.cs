
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home
{
    public class HotelRent : HomeBase
    {
        public int YearBuilt { get; set; }
        public int NumberRoom { get; set; }
        public int ResidenceFloors { get; set; }

        public int ResidenceFloorRent { get; set; }

    }
}
