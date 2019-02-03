using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_7._Speed_Racing
{
    class Car
    {
        //model, fuel amount, fuel consumption for 1 kilometer 
        private string model;       

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int fuelAmount;

        public int FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        private double fuelConsumptionFor1km;

        public double FuelConsumptionFor1km
        {   
            get { return fuelConsumptionFor1km; }
            set { fuelConsumptionFor1km = value; }
        }

        private int distanceTraveled;

        public int DistanceTraveled
        {
            get { return distanceTraveled; }
            set { distanceTraveled = value; }
        }


    }
}
