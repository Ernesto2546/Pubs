using Microsoft.AspNetCore.Mvc;
using PUBS.DOMAIN.Entities;
using PUBS.INFRASTRUCTURE.Context;

namespace PUBS.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorsController : Controller
    {
        private readonly PubsContext _context;

        public AuthorsController(PubsContext context)
        {
             _context = context;
        }

        [HttpGet(Name = "GetAuthors")]
        public IEnumerable<Author> Index()
        {
            var authors = _context.Authors.ToList();
            return authors;
        }
    }
}
