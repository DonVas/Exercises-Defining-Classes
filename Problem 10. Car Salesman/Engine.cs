using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Problem_10._Car_Salesman
{
    public class Engine
    {
        private string model;
        private string power;
        private string displacement;
        private string efficiency;

        public string Model {
            get { return model; }
            set { this.model = value; } }

        public string Power
        {
            get { return power; }
            set { this.power = value; }
        }
        public string Displacement
        {
            get { return displacement; }
            set { this.displacement = value; }
        }
        public string Efficiency
        {
            get { return efficiency; }
            set { this.efficiency = value; }
        }

        public Engine()
        {
            this.model = "";
            this.power = "";
            this.displacement = "n/a";
            this.efficiency = "n/a";
        }
        public Engine(string model,string power):this()
        {
            this.model = model;
            this.power = power;
        }
       
        public Engine(string model, string power,int displacement):this(model,power)
        {
            this.displacement = displacement.ToString();
        }

        public Engine(string model, string power, string efficiency) : this(model, power)
        {
            this.efficiency = efficiency;
        }
        public Engine(string model, string power,int displacement, string efficiency):this(model,power,displacement)
        {
            this.efficiency = efficiency;
        }
    }
}
