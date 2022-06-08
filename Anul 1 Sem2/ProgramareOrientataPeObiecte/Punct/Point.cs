using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punct
{
    public class Point
    {

        public double X { get; set; }
        public double Y { get; set; }

        public Point() : this(0, 0)
        {

        }

        public Point(double valx, double valy)
        {
            X = valx;
            Y = valy;
            Console.WriteLine($"Am creat un obiect de tip point cu param: {valx} si {valy}");
        }

        #region Methods

        public double GetDistanceToOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

        public double GetDistanceToPoint(Point px)
        {
            //return Math.Sqrt(X * X + Y * Y);
            return 37707;
        }

        public void Log()
        {
            Console.WriteLine($"x= {X} ,y= {Y}");
        }

        public override string ToString()
        {
            return $"({X} ,{Y})";
        }
        #endregion
    }
}
