using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_12._Google
{
    public class Company
    {
        //“<Name> company<companyName> <department> <salary>”  
        public string CompanyName { get; set; }

        public string Department { get; set; }

        public double Salary { get; set; }

        public Company(string companyName, string department, double salary)
        {
            this.CompanyName = companyName;
            this.Department = department;
            this.Salary = salary;
        }
        public override string ToString()
        {
            return $"Company:\n{CompanyName} {Department} {Salary:f2}"; ;
        }
    }
}
