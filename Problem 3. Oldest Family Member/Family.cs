using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> Familys { get; set; }=new List<Person>();

        public void AddMember(Person member)
        {
            Familys.Add(member);
        }

        public Person GetOldestMember()
        {
            return this.Familys
                .OrderByDescending(p => p.Age)
                .First();
        }
    }
}
