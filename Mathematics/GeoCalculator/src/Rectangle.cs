using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NachhilfeGeometrie
{
    internal class Rectangle : MathAbbr, IComputation
    {
        private double height, width;

        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        private Position position;

        public Rectangle()
        {
            position = new Position(0, 0);
        }
        public Rectangle(double height, double width) : this()
        {
            this.height = height;
            this.width = width;
        }

        public Rectangle(double side) : this(side, side) { }

        public virtual double ComputeArea()
        {
            return height * width;
        }

        public virtual double ComputeCircumference()
        {
            return (height + width) * 2;
        }

        public override string ToString()
        {
            return String.Format("Rechteck mit Maßen {0:0.###}, {1:0.###}", height, width);
        }

        public virtual string ComputeAndWrite()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.ToString())
            .AppendLine("Fläche " + this.ComputeArea());
            sb.AppendLine("Umfang " + this.ComputeCircumference());
            return sb.ToString();
        }
    }
}
