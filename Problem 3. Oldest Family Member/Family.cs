using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> family { get; set; }=new List<Person>();

        public void AddMember(Person member)
        {
            family.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.family
                .OrderByDescending(p => p.Age)
                .First();
        }
    }
}
