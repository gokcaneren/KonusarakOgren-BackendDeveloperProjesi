using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Core.Models
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string? Phone { get; set; }
        public string? Region { get; set; }


        public ICollection<Order> Orders { get; set; }
    }
}
