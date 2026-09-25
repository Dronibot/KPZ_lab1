using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class TriangleFactory : AShapeFactory
    {
        private int _x;
        private int _y;
        private Color _color;
        private int _width;
        private int _height;

        public TriangleFactory(int x, int y, Color color, int width, int height)
        {

            _x = x;
            _y = y;
            _color = color;
            _width = width;
            _height = height;

        }

        public override Shape CreateShape()
        {
            return new Triangle(_x, _y, _color, _width, _height);
        }
    }
}
