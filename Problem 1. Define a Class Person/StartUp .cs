using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person> persons=new List<Person>();

                Person personZero = new Person();

                personZero.Name = "Pesho";
                personZero.Age =20 ;
                persons.Add(personZero);

                Person personOne=new Person("Gosho",18);
                persons.Add(personOne);

                persons.Add(new Person("Stamat",43));

            persons.ForEach(x=>Console.WriteLine($"{x.Name} {x.Age}"));
        }
    }
}
