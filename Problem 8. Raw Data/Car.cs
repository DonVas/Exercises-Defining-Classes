using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Raw_Data
{
    class Car
    {
        public string Model { get; set; }   
        public Engine Engine=new Engine();
        public Cargo Cargo=new Cargo();
        public List<Tire> Tires = new List<Tire>();

        public Car()
        {

        }

        public Car(string model, Engine engine, Cargo cargo, List<Tire> tires)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
    }
}
