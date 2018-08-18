using App21072018.Core.Domains;
using App21072018.Services.Admin.Models.Categories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace App21072018.Services.Mapping
{
   public class CategoryMapProfile:Profile
    {
        public CategoryMapProfile()
        {
            CreateMap<Category, CategoryListServiceModel>();
            CreateMap<CategoryListServiceModel, Category>();
        }
    }
}
