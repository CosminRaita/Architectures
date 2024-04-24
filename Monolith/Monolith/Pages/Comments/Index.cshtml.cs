using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Monolith.DataAccess;
using Monolith.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monolith.Pages.Comments
{
    public class IndexModel : PageModel
    {
        private readonly BlogDbContext _context;

        public IndexModel(BlogDbContext context)
        {
            _context = context;
        }

        public IList<Comment> Comments { get; set; }

        public async Task OnGetAsync()
        {
            Comments = await _context.Comments.ToListAsync();
        }
    }
}
