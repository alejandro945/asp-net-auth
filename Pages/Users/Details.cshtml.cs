#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp_net_auth.Data;
using asp_net_auth.Models;

namespace asp_net_auth.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly asp_net_auth.Data.asp_net_authContext _context;

        public DetailsModel(asp_net_auth.Data.asp_net_authContext context)
        {
            _context = context;
        }

        public new User User { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            User = await _context.User.FirstOrDefaultAsync(m => m.ID == id);

            if (User == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
