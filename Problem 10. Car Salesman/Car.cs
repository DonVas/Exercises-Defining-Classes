using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Problem_10._Car_Salesman
{
    public class Car
    {
        private string model;
        private Engine engine=new Engine();
        private int? weight;
        private string color;

        public Car()
        {            
            this.color = "n/a";
        }

        public Car(string model,Engine engine):this()
        {
            this.model = model;
            this.engine = engine;
        }

        public Car(string model, Engine engine,int? weight) : this(model,engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine,string color) : this(model, engine)
        {
            this.color = color;
        }

        public Car(string model, Engine engine,int? weight, string color) : this(model, engine,weight)
        {
            this.color = color;
        }

        public override string ToString()
        {
            StringBuilder carBuilder= new StringBuilder();
            carBuilder.AppendLine($"{this.model}:");
            carBuilder.AppendLine($"  {engine.Model}:");
            carBuilder.AppendLine($"    Power: {engine.Power}");
            carBuilder.AppendLine($"    Displacement: {engine.Displacement}");
            carBuilder.AppendLine($"    Efficiency: {engine.Efficiency}");
            carBuilder.AppendLine($"  Weight: {(this.weight == null ? "n/a" : this.weight.ToString())}");
            carBuilder.Append($"  Color: {(this.color==null ? "n/a" : this.color)}");

            return carBuilder.ToString();
        }
    }
}
