using System;

namespace Problem_5._Date_Modifier
{
    public class Program
    {
        public static void Main()
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier dateModifier = new DateModifier();

            Console.WriteLine(dateModifier.CalculateDifference(date1, date2));
        }
    }
}
