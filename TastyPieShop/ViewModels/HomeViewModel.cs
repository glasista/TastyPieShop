﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyPieShop.Models;

namespace TastyPieShop.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
