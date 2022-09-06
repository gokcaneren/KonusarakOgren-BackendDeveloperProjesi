using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Core.Models
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        public int ShipperId { get; set; }
        public Shipper Shipper { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
