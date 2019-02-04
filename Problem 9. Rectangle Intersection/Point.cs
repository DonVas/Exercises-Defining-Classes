using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_9._Rectangle_Intersection
{
    public class Point
    {
        private double horizontal;
        private double vertical;

        public double Horizontal { get;}
        public double Vertical { get; }
        public Point()
        {

        }

        public Point(double x, double y):this()
        {
            this.Horizontal = x;
            this.Vertical = y;
        }
    }
}
