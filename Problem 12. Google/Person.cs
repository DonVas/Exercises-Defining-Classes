using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_12._Google
{
    class Person
    {
        public string Name { get; set; }

        public Car Car { get; set; }

        public Company Company { get; set; }

        public List<Parent> Parents { get; set; }=new List<Parent>();

        public List<Pokemon> Pokemons { get; set; }=new List<Pokemon>();

        public List<Children> Childrens { get; set; }=new List<Children>();

        public Person(string name)
        {
            this.Name = name;
        }
    }
}
