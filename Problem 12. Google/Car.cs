using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_12._Google
{
    public class Car
    {
        private string model;
        private int speed;

        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }

        public override string ToString()
        {
            return $"Car:\n{this.model} {this.speed}";
        }
    }
}
