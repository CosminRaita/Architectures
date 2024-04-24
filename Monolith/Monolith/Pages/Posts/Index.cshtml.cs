using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Monolith.DataAccess;
using Monolith.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monolith.Pages.Posts
{
    public class IndexModel : PageModel
    {
        private readonly BlogDbContext _context;

        public IndexModel(BlogDbContext context)
        {
            _context = context;
        }

        public IList<Post> Posts { get; set; }

        public async Task OnGetAsync()
        {
            Posts = await _context.Posts.ToListAsync();
        }
    }
}
