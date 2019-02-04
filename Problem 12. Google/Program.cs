using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_12._Google
{
    public class Program
    {
        public static void Main()
        {
            List<Person> persons= new List<Person>();

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string personName = tokens[0];

                if (!persons.Exists(p=>p.Name==personName))
                {
                    persons.Add(new Person(personName));
                }

                string action = tokens[1];
                Person person = persons.Find(p=>p.Name==personName);

                if (action== "company")
                {
                   string companyName = tokens[2];
                    string department = tokens[3];
                    double salary = double.Parse(tokens[4]);
                    person.Company = new Company(companyName, department, salary);
                }
                else if (action == "pokemon")
                {
                    string pokemonName = tokens[2];
                    string pokemonType = tokens[3];
                    person.Pokemons.Add(new Pokemon(pokemonName, pokemonType));
                }
                else if (action == "parents")
                {
                    string parentName = tokens[2];
                    string parentBirthday = tokens[3];
                    person.Parents.Add(new Parent(parentName, parentBirthday));
                }
                else if (action == "children")
                {
                    string childName = tokens[2];
                    string childBirthday = tokens[3];
                    person.Childrens.Add(new Children(childName, childBirthday));
                }
                else if (action == "car")
                {
                    string model = tokens[2];
                    int speed = int.Parse(tokens[3]);
                    person.Car = new Car(model, speed);
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            Person personFind = persons.Find(p => p.Name == command);

            Console.WriteLine(personFind.Name);
            Console.WriteLine(personFind.Company==null? "Company:": personFind.Company.ToString());
            Console.WriteLine(personFind.Car==null?"Car:": personFind.Car.ToString());
            Console.WriteLine("Pokemon:");
            personFind.Pokemons.ForEach(Console.WriteLine);
            Console.WriteLine("Parents:");
            personFind.Parents.ForEach(Console.WriteLine);
            Console.WriteLine("Children:");
            personFind.Childrens.ForEach(Console.WriteLine);
        }
    }
}
