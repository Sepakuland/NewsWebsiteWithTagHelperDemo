﻿using Demo.Core.Contracts;
using Demo.Core.Entities;
using System;
using System.Collections.Generic;

namespace Demo.Core.ApplicationService
{
    public class CategoryFacade:ICategoryFacade
    {
        ICategoryRepository categoryRepository;
        public CategoryFacade(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        public IEnumerable<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }
    }
}
