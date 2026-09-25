using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class CircleFactory : AShapeFactory
    {
        private int _x;
        private int _y;
        private Color _color;
        private double _radius;

        public CircleFactory(int x, int y, Color color, double radius) 
        { 
            
            _x = x;
            _y = y;
            _color = color;
            _radius = radius;

        }

        public override Shape CreateShape()
        {
            return new Circle(_x, _y, _color, _radius);
        }
    }
}
