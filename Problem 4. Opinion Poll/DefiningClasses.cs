using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_4._Opinion_Poll
{
    public class DefiningClasses
    {
        public static void Main()
        {
            int numberOfPerson = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < numberOfPerson; i++)
            {
                string[] humanTokens = Console.ReadLine()
                    .Split()
                    .ToArray();
                persons.Add(new Person(humanTokens[0], int.Parse(humanTokens[1])));
            }

            var result = persons.Where(x => x.Age > 30).OrderBy(p => p.Name);

            foreach (var person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
