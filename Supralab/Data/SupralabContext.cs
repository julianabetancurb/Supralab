using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Supralab.Models;

namespace Supralab.Data
{
    public class SupralabContext : DbContext
    {
        public SupralabContext (DbContextOptions<SupralabContext> options)
            : base(options)
        {
        }

        public DbSet<Supralab.Models.Product> Product { get; set; } = default!;
    }
}
