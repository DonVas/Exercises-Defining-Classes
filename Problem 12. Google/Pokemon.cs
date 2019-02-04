using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_12._Google
{
    public class Pokemon
    {
    	
    	//“<Name> pokemon<pokemonName> <pokemonType>”
        public string PokemonName { get; set; }

        public string PokemonType { get; set; }

        public Pokemon(string pokemonName,string pokemonType)
        {
            this.PokemonName = pokemonName;
            this.PokemonType = pokemonType;
        }
        public override string ToString()
        {
            return $"{PokemonName} {PokemonType}"; 
        }
    }
}
