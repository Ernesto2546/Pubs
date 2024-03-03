using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBS.DOMAIN.Entities
{
    public class Countries
    {
        public int Id { get; set; }
        public int CreateUser { get; set; }
        public DateTime CreationDate { get; set; }
        public int ModifiedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int DeleteUser { get; set; }
        public DateTime DeleteDate { get; set; }
        public string Name { get; set; }
    }
}
