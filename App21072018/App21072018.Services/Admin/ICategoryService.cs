using App21072018.Services.Admin.Models.Categories;
using System;
using System.Collections.Generic;
using System.Text;

namespace App21072018.Services.Admin
{
    public interface ICategoryService
    {
       
        IEnumerable<CategoryListServiceModel> GetAll();

        void Create(string name, string description);

        int Total();

        CategoryListServiceModel ById(int id);

        bool Edit(string name, string description);

        bool Delete(int id);
    }
}
