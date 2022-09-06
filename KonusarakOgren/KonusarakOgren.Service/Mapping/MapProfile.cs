using AutoMapper;
using KonusarakOgren.Core.DT0s.Requests;
using KonusarakOgren.Core.DT0s.Respons;
using KonusarakOgren.Core.DT0s.Users;
using KonusarakOgren.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Service.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductUpdateDto>().ReverseMap();
            CreateMap<Product, ProductAddDto>().ReverseMap();
            CreateMap<ProductDto, ProductAddDto>().ReverseMap();

            CreateMap<Product, ProductsWithCategoryDto>();
            //.ForPath(x => x.Categories, o => o.MapFrom(dto => dto.Category));

            CreateMap<Product, ProductsWithBrandDto>();

            CreateMap<ApiUserDto, ApiUser>().ReverseMap();
        }
    }
}
