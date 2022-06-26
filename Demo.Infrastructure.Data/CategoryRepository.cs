using Demo.Core.Contracts;
using Demo.Core.Entities;
using Demo.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Infrastructure.Data
{
    public class CategoryRepository:ICategoryRepository
    {
        private readonly DemoContext context;
        public CategoryRepository(DemoContext demoContext)
        {
            this.context = demoContext;
        }
        public List<Category> GetAll()
        {
            return context.Categories.Include(a => a.News).ToList();
        }
        public Category Get(int id)
        {
            return context.Categories.Include(a => a.News).First(a => a.CategoryId == id);
        }
    }
}
