using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Core.DT0s.Respons
{
    public class ProductsWithBrandDto:ProductDto
    {
        public BrandDto Brands { get; set; }
    }
}
