using AutoMapper;
using KonusarakOgren.Core.DT0s.Requests;
using KonusarakOgren.Core.DT0s.Respons;
using KonusarakOgren.Core.Models;
using KonusarakOgren.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KonusarakOgren.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _service;
        private readonly IMapper _mapper;
        public ProductsController(IMapper mapper, IProductService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _service.GetAllAsync();
            var productsDtos = _mapper.Map<List<ProductDto>>(products.ToList());
            return Ok(productsDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById(int id)
        {
            var product = await _service.GetByIdAsync(id);
            var productDto = _mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithCategory()
        {
            return Ok(await _service.GetProductsWithCategory());
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithBrand()
        {
            return Ok(await _service.GetProductsWithBrand());
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductUpdateDto productDto) 
        {
            await _service.UpdateAsync(_mapper.Map<Product>(productDto));
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductAddDto addProductDto)
        {
            var product=await _service.AddAsync(_mapper.Map<Product>(addProductDto));
            var productDto = _mapper.Map<ProductDto>(product);
            return Ok(productDto);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await _service.GetByIdAsync(id);
            await _service.RemoveAsync(product);
            return Ok();
        }
    }
}
