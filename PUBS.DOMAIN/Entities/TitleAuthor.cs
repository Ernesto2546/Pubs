using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBS.DOMAIN.Entities
{
    public class TitleAuthor
    {
        public string Id { get; set; }
        public string TitleId { get; set; }
        public int Order { get; set; }
        public int RoyalTyper { get; set; }
    }
}
