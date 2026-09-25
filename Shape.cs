using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab1
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }

        protected Shape(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public abstract void Draw(Graphics g);
        public abstract double GetArea();
    }

}
