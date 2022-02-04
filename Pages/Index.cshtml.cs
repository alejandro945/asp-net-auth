using asp_net_auth.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace asp_net_auth.Pages
{
    public class IndexModel : PageModel
    {

        public void OnGet()
        {

        }

        private readonly asp_net_auth.Data.asp_net_authContext _context;

        public IndexModel(asp_net_auth.Data.asp_net_authContext context)
        {
            _context = context;
        }

        private bool UserExists(string username, string password)
        {

            return _context.User.Any(e => e.Username.Equals(username) && e.Password.Equals(password));
        }

        [BindProperty]
        public User User { get; set; }
        

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(User).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(User.Username, User.Password))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            Console.Write("Varela sapa");

            return RedirectToPage("./Users");
        }
    }
}