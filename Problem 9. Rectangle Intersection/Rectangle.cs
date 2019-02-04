using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_9._Rectangle_Intersection
{
    public class Rectangle
    {
        private string id;
        private double width;
        private double height;
       
        private Point PointOfLeftCorner { get; set; }=new Point();

        public string Id
        {
            get
            {
                return this.id;
            }
        }

        public Rectangle(string id, double width, double height, Point point)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            PointOfLeftCorner = point;
        }

        public bool AreIntersect(Rectangle otherRectangle)
        {
            double othervertical = otherRectangle.PointOfLeftCorner.Vertical;
            double otherhorizontal = otherRectangle.PointOfLeftCorner.Horizontal;


            //ugly part must be optimized

            if ((othervertical >= this.PointOfLeftCorner.Vertical && othervertical - otherRectangle.height <= this.PointOfLeftCorner.Vertical && otherhorizontal <= this.PointOfLeftCorner.Horizontal && otherhorizontal + otherRectangle.width >= this.PointOfLeftCorner.Horizontal) ||
                (othervertical >= this.PointOfLeftCorner.Vertical && othervertical - otherRectangle.height <= this.PointOfLeftCorner.Vertical && otherhorizontal >= this.PointOfLeftCorner.Horizontal && otherhorizontal <= this.PointOfLeftCorner.Horizontal + this.width) ||
                (othervertical <= this.PointOfLeftCorner.Vertical && othervertical >= this.PointOfLeftCorner.Vertical - this.height && otherhorizontal <= this.PointOfLeftCorner.Horizontal && otherhorizontal + otherRectangle.width >= this.PointOfLeftCorner.Horizontal) ||
                (othervertical <= this.PointOfLeftCorner.Vertical && othervertical >= this.PointOfLeftCorner.Vertical - this.height && otherhorizontal >= this.PointOfLeftCorner.Horizontal && otherhorizontal <= this.PointOfLeftCorner.Horizontal + this.width))
            {
                return true;
            }
            return false;
        }
    }
}
