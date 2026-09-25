using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace lab1
{
    internal abstract class AShapeFactory
    {
        public abstract Shape CreateShape();

        public void RenderShape(Graphics g) 
        {
            Shape shape = CreateShape();

            Console.WriteLine("Фабрика починає рендеринг:");
            shape.Draw(g);
            Console.WriteLine($"Площа фігури: {shape.GetArea()}");
        }
    }
}
