using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Raw_Data
{
    public class Tire
    {
        public double TirePressure { get; set; } 
        public int TireAge { get; set; }

        public Tire()
        {

        }
        public Tire(double tirePressure,int tireAge)
        {
            this.TirePressure = tirePressure;
            this.TireAge = tireAge;
        }
    }
}
