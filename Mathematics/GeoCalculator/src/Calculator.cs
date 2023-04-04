using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NachhilfeGeometrie
{
    internal class Calculator
    {
        IComputation[] shapes = new IComputation[5];
        Trapezoid t1 = new Trapezoid(8, 6, 9);
        Rectangle r1 = new Rectangle(8, 6);
        Circle k1 = new Circle(8);

        public Calculator() { }

        public void Examples(out string results)
        {
            shapes[0] = t1; shapes[1] = r1; shapes[2] = k1;
            results = "";

            foreach (var v in shapes)
            {
                if (v is null) break;
                results = "" + v;
                results+= $"Fläche: {v.ComputeArea():0.000}," +
                $" Umfang: {v.ComputeCircumference():0.000}\r\n";
            }
        }


    }
}
