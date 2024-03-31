﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStore.Models;

namespace TechStore.Dtos.ProductDtos
{
    public class GetAllProductsDtos
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string ModelName { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public decimal? DiscountValue { get; set; }//10%  0%
        public decimal? DiscountedPrice { get; set; }  // (1500*10)/100
        public int Quantity { get; set; }
        public List<string>? Images { get; set; }
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        public DateTime? DateAdded { get; set; }
        public bool IsDeleted { get; set; }
    }

}
