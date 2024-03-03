using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBS.DOMAIN.Entities
{
    public class Employee
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string Minit { get; set; }
        public string LastName { get; set; }
        public int JobId { get; set; }
        public int JobLevel { get; set; }
        public string PublishersId { get; set; }
        public DateTime HireDate { get; set; }

    }
}
