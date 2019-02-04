using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_12._Google
{
    public class Parent
    {
        public string ParentName { get; set; }

        public string ParentBirthday { get; set; }
        //“<Name> parents<parentName> <parentBirthday>”

        public Parent(string parentName, string parentBirthday)
        {
            this.ParentName = parentName;
            this.ParentBirthday = parentBirthday;
        }
        public override string ToString()
        {
            return $"{ParentName} {ParentBirthday}";
        }
    }
}
