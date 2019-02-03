using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Person>persons=new List<Person>();
            persons.Add(new Person(5));
            persons.Add(new Person("Ads", 0));

            persons.ForEach(x=>Console.WriteLine($"{x.Name} {x.Age}"));        
        }
    }
}
