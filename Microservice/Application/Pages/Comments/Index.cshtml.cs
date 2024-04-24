using CommentService.DataAccess;
using CommentService.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Application.Pages.Comments
{
    public class CommentModel : PageModel
    {
        private readonly CommentDbContext _context;

        public CommentModel(CommentDbContext context)
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
