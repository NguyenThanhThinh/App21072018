using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App21072018.Core.Domains;
using App21072018.EntityFrameworkCore;
using App21072018.EntityFrameworkCore.Repositories;
using App21072018.Services.Admin.Models.Categories;
using AutoMapper.QueryableExtensions;

namespace App21072018.Services.Admin.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly IAppRepository<Category> appRepository;

        public CategoryService(IAppRepository<Category> appRepository)
        {
            this.appRepository = appRepository;
        }
        public CategoryListServiceModel ById(int id)
        {
            throw new NotImplementedException();
        }

        public void Create(string name, string description)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(string name, string description)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryListServiceModel> GetAll()
        {
              return this.appRepository.GetQuery()
                .OrderBy(b => b.Name)
                .ProjectTo<CategoryListServiceModel>()
                .ToList();
        }

        public int Total()
        {
            throw new NotImplementedException();
        }
    }
}
