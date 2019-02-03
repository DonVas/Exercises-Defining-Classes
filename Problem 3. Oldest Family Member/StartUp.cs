using System;
using System.Linq;

namespace DefiningClasses
{
  public class StartUp

    {
        public static void Main()
        {
            int numberOfPerson = int.Parse(Console.ReadLine());

            Family family=new Family();

            for (int i = 0; i < numberOfPerson; i++)
            {
                string[] humanTokens = Console.ReadLine()
                    .Split()
                    .ToArray();
                family.AddMember(new Person(humanTokens[0],int.Parse(humanTokens[1])));
            }

            Person oldPerson = family.GetOldestMember();

            Console.WriteLine($"{oldPerson.Name} {oldPerson.Age}");

        }
    }
}
