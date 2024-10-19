using Domain.Entitys.Home.BaseEntitys;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home
{
    public  class Home : HomeBase
    {
        [Key]
        [Required]
        [Column ("id")]
        public int Id { get; set; }
        [Column ("discription")]
        public string Discription { get; set; }
        [Column ("yearbuilt")]
        public int YearBuilt { get; set; }
        [Column("hometype")]
        public string HomeType { get; set; }

    
    }
}
