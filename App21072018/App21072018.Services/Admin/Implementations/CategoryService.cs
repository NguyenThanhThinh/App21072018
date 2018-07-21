using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App21072018.EntityFrameworkCore;
using App21072018.Services.Admin.Models.Categories;
using AutoMapper.QueryableExtensions;

namespace App21072018.Services.Admin.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly App21072018DbContext db;

        public CategoryService(App21072018DbContext db)
        {
            this.db = db;
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
              return this.db.Categories
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
