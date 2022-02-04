#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using asp_net_auth.Models;

namespace asp_net_auth.Data
{
    public class asp_net_authContext : DbContext
    {
        public asp_net_authContext (DbContextOptions<asp_net_authContext> options)
            : base(options)
        {
        }

        public DbSet<asp_net_auth.Models.User> User { get; set; }
    }
}
