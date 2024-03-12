﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechStore.Models;

namespace TechStore.Context
{
    public class TechStoreContext : IdentityDbContext<TechUser>
    {

       

        public DbSet<Product> Products { get; set; }
       
        public DbSet<Category> Categories { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ProductItem> ProductItems { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Color> Colors { get; set; }
       // public DbSet<Payment> Payment { get; set; }
        public TechStoreContext(DbContextOptions<TechStoreContext> options)
            : base(options)
        {
        }
    }
}
