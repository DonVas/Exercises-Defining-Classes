using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_12._Google
{
    public class Children
    {
        
        //“<Name> children<childName> <childBirthday>”
        public string ChildrenName { get; set; }
        public string ChildrenBirthday { get; set; }

        public Children(string childrenName, string childrenBirthday)
        {
            this.ChildrenName = childrenName;
            this.ChildrenBirthday = childrenBirthday;
        }
        public override string ToString()
        {
            return $"{ChildrenName} {ChildrenBirthday}";
        }
    }
}
