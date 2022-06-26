using Demo.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Demo.Infrastructure.EF
{
    public class DemoContext:DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ads> Ads { get; set; }
    }
}
