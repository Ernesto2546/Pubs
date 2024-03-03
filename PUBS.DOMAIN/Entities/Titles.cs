using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBS.DOMAIN.Entities
{
    public class Titles
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string PublishersId { get; set; }
        public decimal Price { get; set; }
        public decimal Advance { get; set; }
        public int Royalty { get; set; }
        public int YtdSales { get; set; }
        public string Notes { get; set; }
        public DateTime Pubdate { get; set; }
    }
}
