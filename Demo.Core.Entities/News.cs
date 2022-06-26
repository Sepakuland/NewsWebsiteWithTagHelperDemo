using System;

namespace Demo.Core.Entities
{
    public class News
    {
        public News()
        {
            PubDate = DateTime.Now;
        }
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Summery { get; set; }
        public string Text { get; set; }
        public string ImagePath { get; set; }

        public DateTime PubDate { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
