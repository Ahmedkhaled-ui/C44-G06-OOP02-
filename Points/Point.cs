using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Points
{
    public struct Point
    {
        double X;
         double Y;


        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double x { get; set; }
        public double y { get; set; }


    }
}
