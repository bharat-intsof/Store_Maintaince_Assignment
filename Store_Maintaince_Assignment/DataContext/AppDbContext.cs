using Microsoft.EntityFrameworkCore;
using Store_Maintaince_Assignment.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store_Maintaince_Assignment.DataContext
{
    public class AppDbContext : DbContext
    {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
            {

            }
            public DbSet<Bharat_State1> Bharat_State1s { get; set; }
            public DbSet<Bharat_Store> Bharat_Stores { get; set; }
            public DbSet<Bharat_City1> Bharat_City1s { get; set; }
            public DbSet<Bharat_City2> Bharat_City2s { get; set; }
            public DbSet<Bharat_State2> Bharat_State2s { get; set; }
    }
}
