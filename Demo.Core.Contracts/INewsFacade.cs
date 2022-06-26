using Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Contracts
{
    public interface INewsFacade
    {
        IEnumerable<News> GetHotteseNews(int count);
        IEnumerable<News> FindByCategory(int categoryId);
        IEnumerable<News> Search(string text);
        void CreateNews(News news);
        void Delete(int id);
    }
}
