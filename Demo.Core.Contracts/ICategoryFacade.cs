using Demo.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Contracts
{
    public interface ICategoryFacade
    {
        IEnumerable<Category> GetAll();
    }
}
