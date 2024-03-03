using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBS.DOMAIN.Entities
{
    public class Discounts
    {
        public int Id { get; set; }
        public string DiscountType { get; set; }
        public string StoreId { get; set; }
        public int LowQty { get; set; }
        public int HighQty { get; set; }
        public decimal Discount { get; set; }
    }
}
