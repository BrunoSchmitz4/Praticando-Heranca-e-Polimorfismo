using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecQuintApp.EntitiesShape
{
    abstract class Shape
    {
        public Color color { get ; set; }

        public Shape()
        {

        }

        public Shape(Color color)
        {
            this.color = color;
        }

        abstract public double Area();
    }
}
