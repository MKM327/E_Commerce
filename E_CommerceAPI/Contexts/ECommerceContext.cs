﻿using E_CommerceAPI.Models;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace E_CommerceAPI.Contexts
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions options) : base(options)
        {

        }

        public ECommerceContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=E_Commerce;Integrated Security=True;");
        }

        public DbSet<Product>? Products { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<UserProfile>? UserProfiles { get; set; }

    }
}
