using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NachhilfeGeometrie
{
    internal class Circle : MathAbbr, IComputation
    {
        double radius;
        private Position position;

        public Circle()
        {
            position = new Position(0, 0);
        }

        public Circle(double radius) : this()
        {
            this.radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public double ComputeArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double ComputeCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public override string ToString()
        {
            return String.Format("Kreis mit Radius {0:0.###}", radius);
        }

        public string ComputeAndWrite()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString())
            .AppendLine("Fläche " + this.ComputeArea());
            sb.AppendLine("Umfang " + this.ComputeCircumference());
            return sb.ToString();
        }
    }
}
