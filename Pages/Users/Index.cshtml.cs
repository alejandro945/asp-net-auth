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
    public class IndexModel : PageModel
    {
        private readonly asp_net_auth.Data.asp_net_authContext _context;

        public IndexModel(asp_net_auth.Data.asp_net_authContext context)
        {
            _context = context;
        }

        public new IList<User> User { get;set; }
        public User u = RPC.session;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }

        public void Logout()
        {
            RPC.session = null;
        }
    }
}
