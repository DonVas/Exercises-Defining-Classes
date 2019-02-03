using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_5._Date_Modifier
{
    public class DateModifier
    {
        private string dateOne;
        private string dateTwo;

        public string DataOne
        {
            
            set {this.dateOne = value; }
        }

        public string DateTwo
        {
            
            set { this.dateTwo =value; }
        }

        public DateModifier()
        {           
        }

        public DateModifier( string dataOne,string dataTwo)
        {
            this.DataOne = dataOne;
            this.DateTwo = dataTwo;
        }

        public int CalculateDifference(string data1, string data2)
        {
            return Math.Abs((DateTime(data1) - DateTime(data2)).Days);
        }

        static DateTime DateTime(string date)
        {
            var dataArr = date
                .Split()
                .Select(int.Parse)
                .ToArray();

            return new DateTime(dataArr[0],dataArr[1],dataArr[2]);
        }
    }
}
