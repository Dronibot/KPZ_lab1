using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class Triangle : Shape
    {
        public int width { get; set; }
        public int height { get; set; }

        public Triangle(int x, int y, Color Color, int width, int height) : base(x, y, Color)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g)
        {
            Point[] points = new Point[]
            {
                new Point(X + width / 2, Y),
                new Point(X, Y + height),
                new Point(X + width, Y + height)
            };

            using (Brush brush = new SolidBrush(Color))
            {
                g.FillPolygon(brush, points);
            }
        }

        public override double GetArea()
        {
            return (width * height) / 2.0;
        }
    }
}
