
using Beryllium.Models;
using Beryllium.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {}


        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<SmallSlider> SmallSliders { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Testimonials> Testimonials { get; set; }
        public DbSet<IconTextArea> IconTextAreas { get; set; }
    }
}
