using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pim.Models;

namespace pim.Data
{
    public class pimContext : DbContext
    {
        public pimContext (DbContextOptions<pimContext> options)
            : base(options)
        {
        }

        public DbSet<LoginUsuario> LoginUsuario { get; set; } = default!;
    }
}
