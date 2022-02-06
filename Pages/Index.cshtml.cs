using asp_net_auth.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace asp_net_auth.Pages
{
    public class IndexModel : PageModel
    {
        private readonly asp_net_auth.Data.asp_net_authContext _context;
        [BindProperty]
        public new User User { get; set; }
                                                                                                                      #pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public IndexModel(asp_net_auth.Data.asp_net_authContext context)
                                                                                                                      #pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            var u = _context.User.FirstOrDefault(m => m.Username.Equals(User.Username) && m.Password.Equals(User.Password));
            if (u == null)
            {
                return RedirectToPage("./Error");
            }
            else
            {
                RPC.session = u;
                return RedirectToPage("./Users/Index");
            }
        }
    }
}