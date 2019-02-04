using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9._Rectangle_Intersection
{
    public class Program
    {
        public static void Main()
        {
            int[] lineOfCommands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numberOfRectangle = lineOfCommands[0];
            int numberOfIntersection = lineOfCommands[1];

            List<Rectangle> rectangles=new List<Rectangle>();

            for (int i = 0; i < numberOfRectangle; i++)
            {
                string[] rectangleStrings = Console.ReadLine()
                    .Split()
                    .ToArray();
                string id = rectangleStrings[0];
                double width = double.Parse(rectangleStrings[1]);
                double height= double.Parse(rectangleStrings[2]);
                Point point =new Point(double.Parse(rectangleStrings[3]), double.Parse(rectangleStrings[4]));
                rectangles.Add(new Rectangle(id,width,height,point));
            }

            for (int i = 0; i < numberOfIntersection; i++)
            {
                var tokens = Console.ReadLine().Split();

                Rectangle rectangle1 = rectangles.First(r => r.Id == tokens[0]);
                Rectangle rectangle2 = rectangles.First(r => r.Id == tokens[1]);

                if (rectangle1.AreIntersect(rectangle2))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }

        }
    }
}
