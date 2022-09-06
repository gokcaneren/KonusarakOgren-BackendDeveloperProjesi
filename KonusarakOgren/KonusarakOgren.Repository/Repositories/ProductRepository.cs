using KonusarakOgren.Core.Models;
using KonusarakOgren.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProducstWithBrand()
        {
            return await _context.Products.Include(x=>x.Brand).ToListAsync();
        }

        public async Task<List<Product>> GetProducstWithCategory()
        {
            return await _context.Products.Include(x=>x.Category).ToListAsync();
        }
    }
}
