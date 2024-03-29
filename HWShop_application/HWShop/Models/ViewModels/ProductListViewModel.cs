﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HWShop.Models.ViewModels
{
    public class ProductListViewModel
    {
        public PagingInfo PagingInfo { get; set; }
        public IQueryable<Product> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
