using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punct
{
    internal class Program
    {
        static void Main()
        {
            Point pct1 = new Point { X = 10.0, Y = 4.2 };
            pct1.Log();

            Point pct2 = new Point(3, 4);
            pct2.Log();

            Point pct3 = new Point();
            pct3.Log();

            Console.WriteLine();
            Console.WriteLine(pct1);

            Console.WriteLine(pct1.GetDistanceToOrigin());
        }
    }
}
