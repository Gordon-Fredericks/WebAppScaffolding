using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppScaffolding.Models
{
    public class ThingyContext : DbContext
    {
        public ThingyContext(DbContextOptions<ThingyContext> options) : base(options)
        {
        }

        public DbSet<Thingy> Thingy { get; set; }
    }
}
