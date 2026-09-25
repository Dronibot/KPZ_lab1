using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab1
{
    internal class Circle : Shape
    {
        public double radius { get; set; }

        public Circle(int x, int y, Color Color, double Radius) : base(x, y, Color)
        {
            radius = Radius;
        }

        public override void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillEllipse(brush, X, Y, (float)(radius * 2), (float)(radius * 2));
            }
            
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
