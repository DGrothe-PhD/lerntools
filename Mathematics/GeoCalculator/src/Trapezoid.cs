using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NachhilfeGeometrie
{
    internal sealed class Trapezoid : Rectangle
    {
        double upperWidth;
        double angle_in_degrees;
        double rightshift;

        public double UpperWidth { get => upperWidth; set => upperWidth = value; }
        public double Angle
        {
            get
            {
                return angle_in_degrees;
            }
            set
            {
                angle_in_degrees = value == 0 ? 90 : value;
                if (angle_in_degrees == 90)
                    rightshift = 0;
                else
                    rightshift = Height / Math.Tan(DegreeToRadian((double)angle_in_degrees));
            }
        }

        public double RightShift
        {
            get
            {
                return rightshift;
            }
            set
            {
                rightshift = value;
                angle_in_degrees = RadianToDegrees(
                    Math.Asin(Height /
                    Math.Sqrt(Math.Pow(Height, 2) + Math.Pow((double)rightshift, 2))
                ));
                if (rightshift < 0)
                    angle_in_degrees = 180 - angle_in_degrees;
            }
        }

        public Trapezoid() : base() { }
        public Trapezoid(double width, double upperWidth, double height)
            : base(width, height)
        {
            this.upperWidth = upperWidth;
            //default is symmetric
            MakeSymmetric();
        }

        public void MakeSymmetric()
        {
            this.rightshift = (Width - UpperWidth) / 2;

            this.angle_in_degrees = RadianToDegrees(
                Math.Asin(Height /
                Math.Sqrt(Math.Pow(Height, 2) + Math.Pow((double)rightshift, 2))
            ));
        }

        public double Diagonal1() => Hypotenuse(RightShift, Height);
        public double Diagonal2() => Hypotenuse(Width - RightShift - UpperWidth, Height);

        public override double ComputeCircumference()
        {
            return (Width + UpperWidth + Diagonal1() + Diagonal2());
        }

        public override double ComputeArea()
        {
            return (Width + UpperWidth) * Height / 2;
        }

        public override string ToString()
        {
            return String.Format("Trapez, g= {0:0.000}, h={1:0.000}, g'= {2:0.000}",
                Width, Height, UpperWidth);
        }

        public override string ComputeAndWrite()
        {
            string addendum = String.Format("Eckwinkel unten links: {0:0.##} °,\r\n" +
                "Verschiebung der Oberseite: {1:0.##}\r\n", Angle, RightShift);
            return addendum + base.ComputeAndWrite();
        }
    }

}
