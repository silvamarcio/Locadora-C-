using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Locadora.Models;

namespace Locadora.Models
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext (DbContextOptions<LocadoraContext> options)
            : base(options)
        {
        }

        public DbSet<Locadora.Models.Filme> Filme { get; set; }

        public DbSet<Locadora.Models.Locacao> Locacao { get; set; }
    }
}
