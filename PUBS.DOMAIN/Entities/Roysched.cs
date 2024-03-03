using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBS.DOMAIN.Entities
{
    public class Roysched
    {
        public string TitleId { get; set; }
        public int Lorange { get; set; }
        public int Hirange { get; set; }
        public int Royalty { get; set; }
    }
}
