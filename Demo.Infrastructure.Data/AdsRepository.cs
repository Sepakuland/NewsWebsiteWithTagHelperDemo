using Demo.Core.Contracts;
using Demo.Core.Entities;
using Demo.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.Infrastructure.Data
{
    public class AdsRepository:IAdsRepository
    {
        private readonly DemoContext context;
        public AdsRepository(DemoContext demoContext)
        {
            this.context = demoContext;
        }
        public List<Ads> GetAds()
        {
            return context.Ads.ToList();
        }
    }
}
