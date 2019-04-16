using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Locacao
    {
        public int Id { get; set; }
        public double RentalPrice { get; set; }
        public List<Filme> Filmes { get; set; } = new List<Filme>();

        public Locacao()
        {
        }

        public Locacao(int id, double rentalPrice)
        {
            Id = id;
            RentalPrice = rentalPrice;
        }

        public void AddFilme(Filme filme)
        {
            Filmes.Add(filme);
        }

        public void RemoveFilme(Filme filme)
        {
            Filmes.Remove(filme);
        }

        public double SubTotal()
        {
            RentalPrice = 0;

            foreach(Filme f in Filmes)
            {
                RentalPrice = Filmes.Sum(x => x.Price);
            }

            return RentalPrice;
        }
    }
}
