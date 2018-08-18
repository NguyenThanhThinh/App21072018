using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App21072018.Core;
using App21072018.Core.Domains;
using App21072018.EntityFrameworkCore;
using App21072018.EntityFrameworkCore.Repositories;
using App21072018.Services.Admin.Models.Categories;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace App21072018.Services.Admin.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly IAppRepository<Category> appRepository;

        public CategoryService(IAppRepository<Category> appRepository)
        {
            this.appRepository = appRepository;
        }
        public async Task<CategoryListServiceModel> ById(int id)
        {
            var category = await appRepository.GetByIdAsync(id);

            var categoryDto = new CategoryListServiceModel();

            if (category != null)
            {
                categoryDto = Mapper.Map<Category, CategoryListServiceModel>(category);

                return categoryDto;
            }

            return categoryDto;
        }

        public async Task Create(CategoryListServiceModel model)
        {
            var category = Mapper.Map<CategoryListServiceModel, Category>(model);

            await appRepository.InsertAsync(category);

            await appRepository.UnitOfWork.CommitAsync();
        }

        public bool Delete(Category id)
        {
            if (id != null)
            {
                appRepository.Delete(id);
                return true;
            }
            return false;
        }

        public bool Edit(CategoryListServiceModel model)
        {
          
            var getCategory = Mapper.Map<CategoryListServiceModel,Category>(model);
            appRepository.Update(getCategory);
            appRepository.UnitOfWork.CommitAsync();
            return true;

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
            return appRepository.GetQuery().Count();
        }
    }
}
