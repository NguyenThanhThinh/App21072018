using App21072018.Core.Domains;
using App21072018.Services.Admin.Models.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace App21072018.Services.Admin
{
    public interface ICategoryService
    {
       
        IEnumerable<CategoryListServiceModel> GetAll();

        Task Create(CategoryListServiceModel model);

        int Total();

        Task<CategoryListServiceModel> ById(int id);

        bool Edit(CategoryListServiceModel model);

        bool Delete(Category id);
    }
}
