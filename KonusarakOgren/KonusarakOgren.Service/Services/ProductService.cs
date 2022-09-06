using AutoMapper;
using KonusarakOgren.Core.DT0s.Respons;
using KonusarakOgren.Core.Models;
using KonusarakOgren.Core.Repositories;
using KonusarakOgren.Core.Services;
using KonusarakOgren.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Service.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<List<ProductsWithBrandDto>> GetProductsWithBrand()
        {
            var products = await _productRepository.GetProducstWithBrand();
            var productsDto = _mapper.Map<List<ProductsWithBrandDto>>(products);
            return productsDto;
        }

        public async Task<List<ProductsWithCategoryDto>> GetProductsWithCategory()
        {
            var products = await _productRepository.GetProducstWithCategory();
            var productsDto = _mapper.Map<List<ProductsWithCategoryDto>>(products);
            return productsDto;
        }
    }
}
