﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Core.Models
{
    public class Brand : BaseEntity
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
