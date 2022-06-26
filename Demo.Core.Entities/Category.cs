using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public List<News> News { get; set; }
    }
}
