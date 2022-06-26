using Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Models
{
    public class NewsViewModel
    {
        public IEnumerable<News> News { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }
        public IEnumerable<Ads> Ads { get; set; }
    }
}
