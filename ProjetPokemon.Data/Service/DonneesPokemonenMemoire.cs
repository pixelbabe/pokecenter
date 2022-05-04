﻿using ProjetPokemon.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetPokemon.Data.Service
{
    public class DonneesPokemonenMemoire : ISourceDonneesPokemon
    {
        private readonly List<Pokemon> pokemons;

        public DonneesPokemonenMemoire()
        {



            Pokemon p1 = new Pokemon(1, Species.Blastoise, ElementType.Water);
            Pokemon p2 = new Pokemon(2, Species.Pikachu, ElementType.Electric);
            Pokemon p3 = new Pokemon(3, Species.Charizard);
            
            p2.Nickname = "PikaPika";
            
            pokemons = new List<Pokemon>
            {
                p1,p2,p3
            };

        }

        public IEnumerable<Pokemon> GetAll()
        {
            return pokemons.OrderBy(p => p.Name);
        }

        public void Add(Pokemon addPokemon)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Pokemon Get(int id)
        {
            return pokemons.Find(p => p.Id == id);
        }

        public bool Update(Pokemon updatePokemon)
        {
            throw new NotImplementedException();
        }
    }
}
