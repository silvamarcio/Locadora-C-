﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Locadora.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        public Filme()
        {
        }

        public Filme( string title, string genre, double price)
        {
          
            Title = title;
            Genre = genre;
            Price = price;
        }
    }
}
