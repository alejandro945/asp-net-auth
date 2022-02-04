using asp_net_auth.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace asp_net_auth.Pages
{
    public class IndexModel : PageModel
    {

#pragma warning restore CS8618
#pragma warning restore CS8602

        private readonly asp_net_auth.Data.asp_net_authContext _context;

        [BindProperty]
        public new User User { get; set; }

        public IndexModel(Data.asp_net_authContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            return Page();
        }

            public void OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Page();
            }

            RedirectToPage("./Users");
        }

        private bool UserExists(string username, string password)
        {

            return _context.User.Any(e => e.Username.Equals(username) && e.Password.Equals(password));
        
        }
    }
}