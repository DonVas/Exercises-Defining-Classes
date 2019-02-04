using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_11._Pokemon_Trainer
{
    public class Trainer
    {
        public string name;
        public int numberOfBadges = 0;
        public List<Pokemon>collectionPokemons { get; set; }

        public Trainer()
        {

        }
        public Trainer(string name)
        {
            this.Name = name;
            this.CollectionPokemons = new List<Pokemon>();
        }

        public List<Pokemon> CollectionPokemons
        {
            get { return collectionPokemons; }
            private set { collectionPokemons = value; }
        }

        public int NumberOfBadges
        {
            get { return numberOfBadges; }
            private set { numberOfBadges = value; }
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public void AddPokemon(Pokemon pokemon)
        {
            this.CollectionPokemons.Add(pokemon);
        }

        public void IncreaseBadges()
        {
            numberOfBadges++;
        }
        public void ReducePokemonsHealth()
        {
            this.CollectionPokemons.ForEach(p => p.ReduceHealth());
        }

        public void RemoveDead()
        {
            this.CollectionPokemons = this.CollectionPokemons.Where( p => p.Health>0)
                .ToList();
        }

        public override string ToString()
        {
            return $"{Name} {NumberOfBadges} {CollectionPokemons.Count}";
        }
    }
}
