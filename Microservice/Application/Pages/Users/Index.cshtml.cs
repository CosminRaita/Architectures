using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using UserService.DataAccess;
using UserService.Model;

namespace Application.Pages.Users
{
    public class UserModel : PageModel
    {
        private readonly UserDbContext _context;

        public UserModel(UserDbContext context)
        {
            _context = context;
        }

        public IList<User> Users { get; set; }

        public async Task OnGetAsync()
        {
            Users = await _context.Users.ToListAsync();
        }
    }
}
