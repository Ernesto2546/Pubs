using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBS.DOMAIN.Entities
{
    public class Jobs
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinLevel { get; set; }
        public int MaxLevel { get; set; }
    }
}
