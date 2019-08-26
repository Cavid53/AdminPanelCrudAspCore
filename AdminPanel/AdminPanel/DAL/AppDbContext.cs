using AdminPanel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminPanel.DAL
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<RepeatDescription> RepeatDescriptions { get; set; }
        public DbSet<Welcome> Welcomes { get; set; }
        public DbSet<WhatWeDo> WhatWeDos { get; set; }
        public DbSet<Service> Services { get; set; }

    }
}
