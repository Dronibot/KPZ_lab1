using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    internal class Rectangle : Shape
    {
        public int width {  get; set; }
        public int height { get; set; }

        public Rectangle(int x, int y, Color Color, int width, int height) : base(x, y, Color)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g)
        {
            using (Brush brush = new SolidBrush(Color))
            {
                g.FillRectangle(brush, X, Y, width, height);
            }

        }

        public override double GetArea()
        {
            return width * height;
        }
    }
}
