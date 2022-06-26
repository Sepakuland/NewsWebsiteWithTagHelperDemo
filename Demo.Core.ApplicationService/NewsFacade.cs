using Demo.Core.Contracts;
using Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.ApplicationService
{
    public class NewsFacade : INewsFacade
    {
        INewsRepository newsReposiotry;
        public NewsFacade(INewsRepository newsReposiotry)
        {
            this.newsReposiotry = newsReposiotry;
        }

        public IEnumerable<News> GetHotteseNews(int count)
        {
            return newsReposiotry.GetHotestNews(count);
        }


        public IEnumerable<News> FindByCategory(int categoryId)
        {
            return newsReposiotry.FindByCategory(categoryId);
        }

        public IEnumerable<News> Search(string text)
        {
            return newsReposiotry.HomeSearch(text);
        }
        public void CreateNews(News news)
        {
            newsReposiotry.CreateNews(news);
        }
        public void Delete(int id)
        {
            newsReposiotry.Delete(id);
        }


    }
}
