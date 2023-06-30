using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DecQuintApp.EntitiesShape
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle() { }

        public Circle(double radius, Color color)
            :base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            double pi = 3.14f;
            double area;
            area = pi * (Radius * Radius);
            return area;
            //Console.Write($"Área: {area.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
