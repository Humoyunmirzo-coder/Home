using Domain.Entitys.Home.BaseEntitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home
{
    public  class HomeRent : HomeBase
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Column("homeowner")]
        public bool HomeOwner { get; set; }
        [Column("daymonth")]
        public string DayMonth { get; set; }
        /// <summary>
        ///  Day or month type 
        /// </summary>
        [Required]
        [Column("usertype")]
        public string UserType { get; set; }
        /// <summary>
        ///  user type  :   Male     
        ///  user type  :   Woman      
        ///  user type  :   Family       
        /// </summar
    }
}
