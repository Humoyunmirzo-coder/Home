﻿using Domain.Entitys.Home.BaseEntitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entitys.Home
{
    public  class Home : HomeBase
    {
        public int Id { get; set; }
        public string Discription { get; set; }
    }
}
