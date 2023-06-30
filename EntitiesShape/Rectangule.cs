using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DecQuintApp.EntitiesShape
{
    class Rectangule : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangule() { }

        public Rectangule(double width, double height, Color color)
            : base(color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            double area = Width * Height;
            //Console.Write("Área: ");
            return area;
            //Console.WriteLine($"Área: {area.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
