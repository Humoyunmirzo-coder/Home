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
    public  class Hotel : HomeBase
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Column("saymonth")]
        public string DayMonth { get; set; }         /// Day or month time 
        /// <summary>
        /// dd/mm/yyyy
        /// </summary>
        [Column ("id")]
        public string RoomType { get; set; }
        /// <summary>       
        ///  Bissnes
        ///  Comfortable
        ///  Cheap
        /// </summary>
        [Required]
        [Column("iusertype")]
        public string UserType { get; set; }
        /// <summary>
        ///  user type  :   Male     
        ///  user type  :   Woman      
        ///  user type  :   Family       
        /// </summary>
    }
}
