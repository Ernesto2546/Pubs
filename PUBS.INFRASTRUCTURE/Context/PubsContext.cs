using Microsoft.EntityFrameworkCore;
using PUBS.DOMAIN.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUBS.INFRASTRUCTURE.Context
{
    public class PubsContext : DbContext
    {
        public PubsContext(DbContextOptions<PubsContext> options) : base(options)
        {
        }
        public DbSet<Author> Authors { get; set; }
    }
}
