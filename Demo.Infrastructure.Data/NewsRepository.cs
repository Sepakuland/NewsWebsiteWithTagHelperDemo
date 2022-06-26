using Demo.Core.Contracts;
using Demo.Core.Entities;
using Demo.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo.Infrastructure.Data
{
    public class NewsReposiotry : INewsRepository
    {
        private readonly DemoContext context;
        public NewsReposiotry(DemoContext context)
        {
            this.context = context;

        }
        public List<News> GetHotestNews(int count)
        {
            return context.News.OrderByDescending(a => a.PubDate).Take(count).ToList();
        }

        public List<News> HomeSearch(string search)
        {
            return context.News.Where
                (a => a.Title.Contains(search) || a.Summery.Contains(search)).ToList();
        }

        public News Get(int id)
        {
            return context.News.Find(id);
        }

        public List<News> FindByCategory(int categoryId)
        {
            return context.News.Include(a => a.Category)
                .Where(a => a.CategoryId == categoryId).ToList();
        }
        public void CreateNews(News news)
        {
            context.Add(news);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            context.News.Remove(new News() { NewsId = id });
            context.SaveChanges();
        }
    }
    public class NewsNoSqlRepository : INewsRepository
    {
        public void CreateNews(News news)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<News> FindByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public News Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<News> GetHotestNews(int count)
        {
            throw new NotImplementedException();
        }

        public List<News> HomeSearch(string search)
        {
            throw new NotImplementedException();
        }
        
    }
}
