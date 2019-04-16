using Locadora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Data
{
    public class SeedingService
    {

        private LocadoraContext _context;

        public SeedingService(LocadoraContext context)
        {
            _context = context;
        }

        public void seed()
        {
            if (_context.Filme.Any())
            {
                return; // DB has been seed.
            }

            Filme f1 = new Filme("Piratas do caribe","Action",5.00);
            Filme f2 = new Filme( "Missão impossivel", "Action", 4.00);
            Filme f3 = new Filme( "American Pie", "Comedy", 5.00);
            Filme f4 = new Filme( "The hangout", "Comedy", 4.00);
            Filme f5 = new Filme( "Pier Harbor", "War", 4.00);
            Filme f6 = new Filme( "Sniper", "War", 3.50);
            Filme f7 = new Filme( "The Silence", "Drama", 5.00);
            Filme f8 = new Filme( "One Piece", "Anime", 5.00);
            Filme f9 = new Filme( "Roma", "Drama", 3.00);
            Filme f10 = new Filme( "Rua Cloverfield 10", "Suspense", 5.00);

            _context.Filme.AddRange(f1,f2,f3,f4,f5,f6,f7,f8,f9,f10);
            _context.SaveChanges();
        }
    }
}
