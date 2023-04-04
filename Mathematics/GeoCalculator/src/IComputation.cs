using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NachhilfeGeometrie
{
    internal class MathAbbr{
        public static double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public static double RadianToDegrees(double angle)
        {
            return 180.0 * angle / Math.PI;
        }

        public static double Hypotenuse(double x, double y)
        {
            return Math.Sqrt(x * x + y * y);
        }
    }

    internal interface IComputation
    {
        public double ComputeArea();
        public double ComputeCircumference();

        public string ComputeAndWrite();
    }
}
