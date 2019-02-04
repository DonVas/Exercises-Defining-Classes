using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Raw_Data
{
    public class Cargo
    {
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }

        public Cargo()
        {

        }
        public Cargo(int cargoWeight, string cargoType):this()
        {
            this.CargoWeight = cargoWeight;
            this.CargoType = cargoType;
        }
        
    }
}
