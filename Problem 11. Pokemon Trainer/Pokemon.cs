﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace Problem_11._Pokemon_Trainer
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;

        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }
        public int Health
        {
            get { return this.health; }
            private set { this.health = value; }
        }

        public string Element
        {
            get { return this.element; }
            private set { this.element = value; }
        }

        public void ReduceHealth()
        {
            this.Health -= 10;
        }
    }
}
