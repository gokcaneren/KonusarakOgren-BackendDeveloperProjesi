using KonusarakOgren.Core.DT0s.Respons;
using KonusarakOgren.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Core.Services
{
    public interface IProductService:IService<Product>
    {
        Task<List<ProductsWithCategoryDto>> GetProductsWithCategory();
        Task<List<ProductsWithBrandDto>> GetProductsWithBrand();
    }
}
