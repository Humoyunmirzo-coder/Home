using Domain.Entitys.Home.SpareParts.SparePartBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home.SpareParts
{
    public class HomeAppliance : HomeSparePartBase
    {

        public int  Id { get; set; }
        public string HomeApplianceType { get; set; }
        public string BrendType { get; set; }
        public string NumberOfProduct { get; set; }
        public DateTime  IssueDateTime { get; set; }
      



    }
}
