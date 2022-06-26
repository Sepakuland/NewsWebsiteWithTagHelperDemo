using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo.Core.Contracts;
using Demo.Core.Entities;
using Demo.Infrastructure.Data;
using Demo1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo1.Controllers
{
    public class NewsController : Controller
    {
        INewsFacade newsFacade;
        ICategoryFacade categoryFacade;
        public NewsController(INewsFacade newsFacade, ICategoryFacade categoryFacade)
        {
            this.newsFacade = newsFacade;
            this.categoryFacade = categoryFacade;
        }
        public IActionResult Index(int categoryId, string search)
        {
            IEnumerable<News> news = new List<News>();

            if (!string.IsNullOrEmpty(search))
            {
                news = newsFacade.Search(search);
            }
            else if (categoryId != 0)
            {
                news = newsFacade.FindByCategory(categoryId);
            }
            else
            {
                news = newsFacade.GetHotteseNews(5);
            }


            IEnumerable<Category> categories = categoryFacade.GetAll();

            List<CategoryViewModel> categoryViewModels = new List<CategoryViewModel>();
            foreach (var item in categories)
            {
                CategoryViewModel vm = new CategoryViewModel();
                vm.CategoryId = item.CategoryId;
                vm.Title = item.Title;
                vm.NewsCount = item.News.Count;
                categoryViewModels.Add(vm);
            }

            NewsViewModel model = new NewsViewModel()
            {
                News = news,
                Categories = categoryViewModels

            };
            return View(model);
        }
        public IActionResult CreateNews()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateNews(News model)
        {
            if (ModelState.IsValid)
            {
                News news = new News
                {
                    Title = model.Title,
                    CategoryId = model.CategoryId,
                    Text = model.Text,
                    Summery = model.Summery,
                    PubDate = model.PubDate,
                };
                newsFacade.CreateNews(news);
            }
            return RedirectToAction("Index", "News");
        }
        public IActionResult Delete(int id)
        {
                newsFacade.Delete(id);
                return RedirectToAction("index");
        }
    }
}