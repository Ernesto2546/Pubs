using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBS.DOMAIN.Entities
{
    public class Author
    {
        [Column("au_id")]
        public string Id { get; set; }

        [Column("au_lname")]
        public string LastName { get; set; }

        [Column("au_fname")]
        public string FirstName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Boolean Contract { get; set; }
    }
}
