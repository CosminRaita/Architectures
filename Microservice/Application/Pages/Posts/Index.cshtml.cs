using Microservice.DataAccess;
using Microservice.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Application.Pages.Posts
{
    public class PostModel : PageModel
    {
        private readonly PostDbContext _context;

        public PostModel(PostDbContext context)
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
