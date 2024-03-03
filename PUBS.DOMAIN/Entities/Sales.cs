using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBS.DOMAIN.Entities
{
    public class Sales
    {
        public string StoreId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public int Qty { get; set; }
        public string PayTerms { get; set; }
        public string TitleId { get; set; }
    }
}
