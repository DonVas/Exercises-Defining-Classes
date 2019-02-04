using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_11._Pokemon_Trainer
{
    public class Program
    {
        public static void Main()
        {
            string[] pokemonStrings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Trainer> trainers= new List<Trainer>();

            while (pokemonStrings[0]!= "Tournament")
            {
                string trainerName = pokemonStrings[0];
                string pokemonName = pokemonStrings[1];
                string pokemonElement = pokemonStrings[2];

                int pokemonHealth = int.Parse(pokemonStrings[3]);

                if (!trainers.Any(t => t.Name == trainerName))
                {
                    trainers.Add(new Trainer(trainerName));
                }

                Trainer trainer = trainers.First(t => t.Name == trainerName);

                trainer.AddPokemon(new Pokemon(pokemonName, pokemonElement, pokemonHealth));

                pokemonStrings = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
            }

            string pokemonElements = Console.ReadLine();
                

            while (pokemonElements!="End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.collectionPokemons.Any(p => p.Element == pokemonElements))
                    {
                        trainer.IncreaseBadges();
                    }
                    else
                    {
                        trainer.ReducePokemonsHealth();
                        trainer.RemoveDead();
                    }
                }

                pokemonElements = Console.ReadLine();
            }

            trainers
                .OrderByDescending(t => t.numberOfBadges)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
