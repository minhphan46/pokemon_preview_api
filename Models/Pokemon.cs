﻿namespace PokemonPreview.Models
{
    public class Pokemon
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public ICollection<PokemonCategory> PokemonCategories { get; set; }

        public ICollection<PokemonOwner> PokemonOwner { get; set; }
    }
}
