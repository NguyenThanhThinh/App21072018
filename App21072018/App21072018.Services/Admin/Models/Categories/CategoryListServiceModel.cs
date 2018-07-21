using App21072018.Common;
using App21072018.Core.Domains;
using AutoMapper;

namespace App21072018.Services.Admin.Models.Categories
{
    public class CategoryListServiceModel: IMapFrom<Category>,IHaveCustomMapping
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<Category, CategoryListServiceModel>()
              .ForMember(b => b.Name, cfg => cfg.MapFrom(b => b.Name));
        }
    }
}
